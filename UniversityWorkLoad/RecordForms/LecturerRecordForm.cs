using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.RecordForms
{
    [DbComplexForm(typeof(Lecturer))]
    public partial class LecturerRecordForm : Form, IRecordForm, IFormValidate
    {
        private byte[] _photo;

        public LecturerRecordForm(IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            InitializeComponent();
            InitializeComboBoxes(bindingsList);
            _photo = Array.Empty<byte>();
            _photoBitmap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public LecturerRecordForm(Lecturer lecturer, IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            InitializeComponent();
            InitializeComboBoxes(bindingsList);
            _surnameBox.Text = lecturer.Surname;
            _nameBox.Text = lecturer.Name;
            _middleNameBox.Text = lecturer.MiddleName;
            _positionBox.SelectedItem = lecturer.Position;
            _facultyBox.SelectedItem = lecturer.Faculty;
            LoadBitmap(lecturer.Photo);
            _photoBitmap.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadBitmap(byte[] photoStream)
        {
            using var ms = new MemoryStream(photoStream);
            _photoBitmap.Image = Image.FromStream(ms);
        }

        private void InitializeComboBoxes(IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            _positionBox.DataSource = bindingsList[typeof(Position)];
            _facultyBox.DataSource = bindingsList[typeof(Faculty)];
        }

        public object[] GetParams() => new object[]
        {
            _surnameBox.Text, _nameBox.Text, _middleNameBox.Text,
            (Position)_positionBox.SelectedItem, (Faculty)_facultyBox.SelectedItem, _photo
        };

        public bool IsValid()
        {
            var parameters = GetParams();
            foreach (var param in parameters)
            {
                switch (param)
                {
                    case "":
                    case byte[] bytes when bytes == Array.Empty<byte>():
                        return false;
                }
            }
            return true;
        }

        private void LecturerRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsValid() || DialogResult != DialogResult.OK) return;
            e.Cancel = true;
            DialogResult = DialogResult.None;
            IFormValidate.NotValidMsg();
        }

        private void SelectPhoto()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            var photoPath = ofd.FileName;
            if (!Regex.IsMatch(photoPath, "^.*\\.(jpg|jpeg|png|bmp)$"))
            {
                _pathBox.Text = "Неверный формат файла";
                return;
            }
            _pathBox.Text = photoPath;
            _photo = File.ReadAllBytes(photoPath);
            LoadBitmap(_photo);
        }

        private void _loadPhotoButton_Click(object sender, EventArgs e) => SelectPhoto();
    }
}
