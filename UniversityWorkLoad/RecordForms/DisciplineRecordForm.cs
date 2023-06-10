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
    [DbSimpleForm(typeof(Discipline))]
    public partial class DisciplineRecordForm : Form, IRecordForm, IFormValidate
    {
        public DisciplineRecordForm()
        {
            InitializeComponent();
        }
        public DisciplineRecordForm(Discipline discipline)
        {
            InitializeComponent();
            _disciplineBox.Text = discipline.DisciplineName;
        }

        public object[] GetParams() => new object[] { _disciplineBox.Text };

        public bool IsValid() => _disciplineBox.Text != string.Empty;

        private void DisciplineRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsValid() || DialogResult != DialogResult.OK) return;
            e.Cancel = true;
            DialogResult = DialogResult.None;
            IFormValidate.NotValidMsg();
        }
    }
}
