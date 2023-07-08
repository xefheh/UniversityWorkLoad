using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.ExcelObjects;

namespace UniversityWorkLoad.ReportForm
{
    public partial class TotalForm : Form
    {
        private BindingList<WorkCard> _workCards;
        public TotalForm(BindingList<WorkCard> workCards)
        {
            InitializeComponent();
            _workCards = workCards;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            new TotalReport(_workCards, _startPicker.Value, _endPicker.Value).MakeReport();
        }
    }
}
