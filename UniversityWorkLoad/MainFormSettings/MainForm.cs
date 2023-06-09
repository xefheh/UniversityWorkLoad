using UniversityWorkLoad.Infrastructure;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad.MainFormSettings
{
    public partial class MainForm : Form
    {
        private ToolColorCommand _lastColorCommand;
        private readonly DataAdapter _adapter;

        public MainForm(DataAdapter adapter)
        {
            InitializeComponent();
            _adapter = adapter;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}