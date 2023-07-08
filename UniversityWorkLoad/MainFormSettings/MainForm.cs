using System.Data;
using System.Diagnostics;
using ClosedXML.Excel;
using UniversityWorkLoad.ExcelObjects;
using UniversityWorkLoad.Infrastructure;
using UniversityWorkLoad.ReportForm;

namespace UniversityWorkLoad.MainFormSettings
{
    public partial class MainForm : Form
    {
        private bool _isFiltered;
        private dynamic _currentController;
        private ToolColorCommand _lastColorCommand;
        private readonly Dictionary<string, dynamic> _dataGridViewControllers;

        public MainForm(Dictionary<string, dynamic> dataGridViewControllers)
        {
            InitializeComponent();
            _dataGridViewControllers = dataGridViewControllers;
            _currentController = _dataGridViewControllers.First().Value;
            âûãðóçèòüÊàðòóToolStripMenuItem.Visible = false;
            _isFiltered = false;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            _mainGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _lastColorCommand = new ToolColorCommand(Discipline);
            _lastColorCommand.MakeAction();
            _filterBox.TextBox.PlaceholderText = "Ââîä ôèëüòðà";
            report.Visible = false;
            InitializeAllEvents();
        }

        private void InitializeAllEvents()
        {
            Faculty.Click += ColorClickHandler;
            Faculty.Click += UpdateDataSource;
            Discipline.Click += ColorClickHandler;
            Discipline.Click += UpdateDataSource;
            StudyGroup.Click += ColorClickHandler;
            StudyGroup.Click += UpdateDataSource;
            Position.Click += ColorClickHandler;
            Position.Click += UpdateDataSource;
            Lecturer.Click += ColorClickHandler;
            Lecturer.Click += UpdateDataSource;
            WorkLoadLine.Click += ColorClickHandler;
            WorkLoadLine.Click += UpdateDataSource;
            WorkCard.Click += ColorClickHandler;
            WorkCard.Click += UpdateDataSource;
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            _currentController.ShowForm();
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = (_isFiltered) ? 
                GetFilteredRecords() :
                _currentController.GetBindingRecords();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (_mainGridView.SelectedRows.Count == 0) return;
            var id = _mainGridView.SelectedRows[0].Cells[0].Value;
            _currentController.ShowForm(id);
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = (_isFiltered) ? GetFilteredRecords() :
                _currentController.GetBindingRecords();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (_mainGridView.SelectedRows.Count == 0) return;
            var id = _mainGridView.SelectedRows[0].Cells[0].Value;
            _currentController.RemoveRecord(id);
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = (_isFiltered) ? GetFilteredRecords() :
                _currentController.GetBindingRecords();
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

        private DataTable GenerateDataTable()
        {
            var dt = new DataTable();
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

        private void _filterBox_TextChanged(object sender, EventArgs e)
        {
            _isFiltered = !string.IsNullOrEmpty(_filterBox.Text);
            _mainGridView.DataSource = GetFilteredRecords();
        }

        private dynamic GetFilteredRecords() => _currentController
            .GetByFilterRecords(_filterBox.Text);

        private void îò÷¸òÏîÄèñöèïëèíàìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LecturerDisciplineForm(_dataGridViewControllers["Lecturer"].GetBindingRecords(),
                _dataGridViewControllers["WorkCard"].GetBindingRecords()).ShowDialog();
        }

        private void îáùèéÎò÷¸òToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TotalForm(_dataGridViewControllers["WorkCard"].GetBindingRecords()).ShowDialog();
        }
    }
}