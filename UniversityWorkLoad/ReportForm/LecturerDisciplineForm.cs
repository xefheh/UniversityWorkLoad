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
    public partial class LecturerDisciplineForm : Form
    {
        private BindingList<WorkCard> _workCards;

        public LecturerDisciplineForm(BindingList<Lecturer> lecturers, BindingList<WorkCard> workCards)
        {
            InitializeComponent();
            _lecturerBox.DataSource = lecturers;
            _workCards = workCards;
        }

        private void _buttonOk_Click(object sender, EventArgs e)
        {
            new LecturerDisciplinesReport(_workCards, _startPicker.Value, _endPicker.Value, (Lecturer)_lecturerBox.SelectedItem).MakeReport();
        }
    }
}
