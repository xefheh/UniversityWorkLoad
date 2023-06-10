using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.RecordForms
{
    [DbComplexForm(typeof(WorkCard))]
    public partial class WorkCardRecordForm : Form, IRecordForm, IFormValidate
    {
        public WorkCardRecordForm(IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            InitializeComponent();
            InitializeComboBoxes(bindingsList);
        }

        public WorkCardRecordForm(WorkCard workCard, IReadOnlyDictionary<Type, dynamic> bindingsList)
        {
            InitializeComponent();
            InitializeComboBoxes(bindingsList);
            _startTimePicker.Value = workCard.StartPeriod.ToDateTime(TimeOnly.MinValue);
            _endTimePicker.Value = workCard.EndPeriod.ToDateTime(TimeOnly.MinValue);
        }

        private void InitializeComboBoxes(IReadOnlyDictionary<Type, dynamic> bindingsList) =>
            _lecturerBox.DataSource = bindingsList[typeof(Lecturer)];

        public object[] GetParams() => new object[]
        {
            DateOnly.FromDateTime(_startTimePicker.Value),
            DateOnly.FromDateTime(_endTimePicker.Value),
            (Lecturer)_lecturerBox.SelectedItem
        };

        public bool IsValid() => _startTimePicker.Value < _endTimePicker.Value;

        private void WorkCardRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsValid() || DialogResult != DialogResult.OK) return;
            e.Cancel = true;
            DialogResult = DialogResult.None;
            IFormValidate.NotValidMsg();
        }
    }
}
