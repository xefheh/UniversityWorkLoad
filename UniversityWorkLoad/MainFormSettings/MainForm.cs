using UniversityWorkLoad.Infrastructure;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad.MainFormSettings
{
    public partial class MainForm : Form
    {
        private ToolColorCommand _lastColorCommand;
        private readonly Dictionary<Type, dynamic> _dgvControllers;

        public MainForm(Dictionary<Type, dynamic> dgvControllers)
        {
            InitializeComponent();
            _dgvControllers = dgvControllers;
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

        private void _toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var controller in _dgvControllers.Values)
            {
                controller.LoadData(_mainGridView);
            }
        }
    }
}