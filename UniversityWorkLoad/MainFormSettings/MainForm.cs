using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniversityWorkLoad.Infrastructure;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad.MainFormSettings
{
    public partial class MainForm : Form
    {
        private dynamic _currentController;
        private ToolColorCommand _lastColorCommand;
        private readonly Dictionary<Type, dynamic> _dataGridViewControllers;

        public MainForm(Dictionary<Type, dynamic> dataGridViewControllers)
        {
            InitializeComponent();
            _dataGridViewControllers = dataGridViewControllers;
            _currentController = _dataGridViewControllers.First().Value;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            _mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            _currentController.ShowForm();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (_mainGridView.SelectedRows.Count == 0) return;
            var id = _mainGridView.SelectedRows[0].Cells[0].Value;
            _currentController.ShowForm(id);
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (_mainGridView.SelectedRows.Count == 0) return;
            var id = _mainGridView.SelectedRows[0].Cells[0].Value;
            _currentController.RemoveRecord(id);
        }

        private void ñîõðàíèòüÁàçóÄàííûõToolStripMenuItem_Click(object sender, EventArgs e) =>
            _currentController.InvokeSaving();
    }
}