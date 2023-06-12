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
            this.âûãðóçèòüÊàðòóToolStripMenuItem.Visible = false;
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "XLSX|*.xlsx|XLS|*.xls";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var path = sfd.FileName;
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
                dt.Columns.Add(column.HeaderText);
            foreach (DataGridViewRow row in _mainGridView.Rows)
                dt.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value.ToString()).ToArray());
            return dt;
        }

        private void âûãðóçèòüÊàðòóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mainGridView.SelectedRows.Count == 0) return;
            var id = _mainGridView.SelectedRows[0].Cells[0].Value;
            var card = _currentController.GetCardById(id);
            new WorkCardReport(card).MakeReport();
        }
    }
}