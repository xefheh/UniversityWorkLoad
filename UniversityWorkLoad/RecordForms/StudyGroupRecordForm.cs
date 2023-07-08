using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.RecordForms
{
    [DbSimpleForm(typeof(StudyGroup))]
    public partial class StudyGroupRecordForm : Form, IRecordForm, IFormValidate
    {
        public StudyGroupRecordForm()
        {
            InitializeComponent();
            Text = "Добавление учебной группы";
        }

        public StudyGroupRecordForm(StudyGroup group)
        {
            InitializeComponent();
            _groupName.Text = group.GroupName;
            Text = "Изменение учебной группы";
        }

        public object[] GetParams() => new object[] { _groupName.Text };

        public bool IsValid() => _groupName.Text != string.Empty;

        private void StudyGroupRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsValid() || DialogResult != DialogResult.OK) return;
            e.Cancel = true;
            DialogResult = DialogResult.None;
            IFormValidate.NotValidMsg();
        }
    }
}
