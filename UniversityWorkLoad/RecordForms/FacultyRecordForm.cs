using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Exceptions;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.RecordForms
{
    [DbSimpleForm(typeof(Faculty))]
    public partial class FacultyRecordForm : Form, IFormValidate, IRecordForm
    {
        public FacultyRecordForm()
        {
            InitializeComponent();
            Text = "Создание кафедры";
        }

        public FacultyRecordForm(Faculty faculty)
        {
            InitializeComponent();
            _facultyNameBox.Text = faculty.FacultyName;
            Text = "Изменение кафедры";
        }

        public object[] GetParams() => new object[] { _facultyNameBox.Text };

        public bool IsValid() => _facultyNameBox.Text != string.Empty;

        private void FacultyRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsValid() || DialogResult != DialogResult.OK) return;
            e.Cancel = true;
            DialogResult = DialogResult.None;
            IFormValidate.NotValidMsg();
        }
    }
}
