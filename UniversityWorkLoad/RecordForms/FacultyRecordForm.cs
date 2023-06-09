using UniversityWorkLoad.Infrastructure;

namespace UniversityWorkLoad.RecordForms
{
    public partial class FacultyRecordForm : Form
    {
        public FacultyRecordForm()
        {
            InitializeComponent();
        }

        public object[] GetParams() => new object[] { _facultyNameBox.Text };
    }
}
