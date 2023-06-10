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
    [DbComplexForm(typeof(WorkLoadLine))]
    public partial class WorkLoadLineRecordForm : Form, IRecordForm, IFormValidate
    {
        public WorkLoadLineRecordForm(IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            InitializeComponent();
            InitializeComboBoxes(bindingsList);
        }

        public WorkLoadLineRecordForm(WorkLoadLine line, IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            InitializeComponent();
            InitializeComboBoxes(bindingsList);
            _cardBox.SelectedItem = line.WorkCard;
            _disciplineBox.SelectedItem = line.Discipline;
            _groupBox.SelectedItem = line.StudyGroup;
            _lectureHours.Value = line.LectureHours;
            _practiceHours.Value = line.PracticeHours;
            _otherHours.Value = line.OtherHours;
        }

        private void InitializeComboBoxes(IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            _cardBox.DataSource = bindingsList[typeof(WorkCard)];
            _disciplineBox.DataSource = bindingsList[typeof(Discipline)];
            _groupBox.DataSource = bindingsList[typeof(StudyGroup)];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public object[] GetParams() => new object[]
        {
            (WorkCard)_cardBox.SelectedItem,
            (Discipline)_disciplineBox.SelectedItem,
            (StudyGroup)_groupBox.SelectedItem,
            (int)_lectureHours.Value,
            (int)_practiceHours.Value,
            (int)_otherHours.Value
        };

        public bool IsValid() => _lectureHours.Value + _practiceHours.Value + _otherHours.Value > 0;

        private void WorkCardLineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsValid() || DialogResult != DialogResult.OK) return;
            e.Cancel = true;
            DialogResult = DialogResult.None;
            IFormValidate.NotValidMsg();
        }
    }
}
