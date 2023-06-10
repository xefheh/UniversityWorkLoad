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
    [DbSimpleForm(typeof(Position))]
    public partial class PositionRecordForm : Form, IRecordForm, IFormValidate
    {
        public PositionRecordForm()
        {
            InitializeComponent();
        }

        public PositionRecordForm(Position position)
        {
            InitializeComponent();
            _positionNameBox.Text = position.PositionName;
            _upNumeric.Value = position.UpLimit;
            _downNumeric.Value = position.LowerLimit;
        }

        public object[] GetParams() => new object[] { _positionNameBox.Text, (int)_upNumeric.Value, (int)_downNumeric.Value };

        public bool IsValid() => _positionNameBox.Text != string.Empty &&
                                 _upNumeric.Value > _downNumeric.Value;

        private void PositionRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsValid() || DialogResult != DialogResult.OK) return;
            e.Cancel = true;
            DialogResult = DialogResult.None;
            IFormValidate.NotValidMsg();
        }
    }
}
