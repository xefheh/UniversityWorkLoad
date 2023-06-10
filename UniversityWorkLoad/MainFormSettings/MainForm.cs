using ClosedXML.Excel;
using System.Collections;
using System.Data;
using UniversityWorkLoad.Infrastructure;
using UniversityWorkLoad.StorageInfo;
using DataTable = DocumentFormat.OpenXml.Drawing.Charts.DataTable;

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

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e) =>
            _currentController.InvokeSaving();

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            var filterText = toolStripTextBox1.Text.Trim();
            var filterValues = filterText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!string.IsNullOrEmpty(filterText))
                _mainGridView.Rows.Cast<DataGridViewRow>().ToList().ForEach(row => row.Visible = filterValues.All(
                    filterValue => row.Cells.Cast<DataGridViewCell>().Any(cell => cell.Value != null &&
                        filterValue.Contains(cell.Value.ToString()))));
            else
                _mainGridView.Rows.Cast<DataGridViewRow>().ToList().ForEach(row => row.Visible = true);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "XLSX|*.xlsx|XLS|*.xls";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var path = sfd.FileName;
            var headers = _mainGridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText).ToList();
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add();
            var table = GenerateDataTable();
            worksheet.Cell(1, 1).InsertTable(table);
            worksheet.Columns().AdjustToContents();
            workbook.SaveAs(path);
        }

        private System.Data.DataTable GenerateDataTable()
        {
            var dt = new System.Data.DataTable();
            foreach (DataGridViewColumn column in _mainGridView.Columns)
                dt.Columns.Add(column.HeaderText, column.HeaderCell.ValueType);
            foreach (DataGridViewRow row in _mainGridView.Rows)
                dt.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
            return dt;
        }
    }
}