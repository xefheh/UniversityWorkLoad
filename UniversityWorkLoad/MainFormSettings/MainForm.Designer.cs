using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Infrastructure;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UniversityWorkLoad.MainFormSettings
{
    public partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem Position;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this._toolStrip = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Faculty = new System.Windows.Forms.ToolStripMenuItem();
            this.StudyGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.Discipline = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lecturer = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkCard = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkLoadLine = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётПоДисциплинамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._addButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this._filterLabel = new System.Windows.Forms.ToolStripLabel();
            this._filterBox = new System.Windows.Forms.ToolStripTextBox();
            this._mainGridView = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Position
            // 
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(167, 22);
            this.Position.Text = "Должности";
            // 
            // _toolStrip
            // 
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.сохранитьБазуДанныхToolStripMenuItem,
            this.выгрузитьКартуToolStripMenuItem,
            this.report});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(609, 24);
            this._toolStrip.TabIndex = 1;
            this._toolStrip.Text = "_toolStrip";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Faculty,
            this.Position,
            this.StudyGroup,
            this.Discipline});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // Faculty
            // 
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(167, 22);
            this.Faculty.Text = "Кафедры";
            // 
            // StudyGroup
            // 
            this.StudyGroup.Name = "StudyGroup";
            this.StudyGroup.Size = new System.Drawing.Size(167, 22);
            this.StudyGroup.Text = "Учебные группы";
            // 
            // Discipline
            // 
            this.Discipline.Name = "Discipline";
            this.Discipline.Size = new System.Drawing.Size(167, 22);
            this.Discipline.Text = "Дисциплины";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lecturer,
            this.WorkCard,
            this.WorkLoadLine});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // Lecturer
            // 
            this.Lecturer.Name = "Lecturer";
            this.Lecturer.Size = new System.Drawing.Size(159, 22);
            this.Lecturer.Text = "Преподаватели";
            // 
            // WorkCard
            // 
            this.WorkCard.Name = "WorkCard";
            this.WorkCard.Size = new System.Drawing.Size(159, 22);
            this.WorkCard.Text = "Карточки";
            // 
            // WorkLoadLine
            // 
            this.WorkLoadLine.Name = "WorkLoadLine";
            this.WorkLoadLine.Size = new System.Drawing.Size(159, 22);
            this.WorkLoadLine.Text = "Нагрузки";
            // 
            // сохранитьБазуДанныхToolStripMenuItem
            // 
            this.сохранитьБазуДанныхToolStripMenuItem.Name = "сохранитьБазуДанныхToolStripMenuItem";
            this.сохранитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.сохранитьБазуДанныхToolStripMenuItem.Text = "Сохранить базу данных";
            this.сохранитьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.сохранитьБазуДанныхToolStripMenuItem_Click);
            // 
            // выгрузитьКартуToolStripMenuItem
            // 
            this.выгрузитьКартуToolStripMenuItem.Name = "выгрузитьКартуToolStripMenuItem";
            this.выгрузитьКартуToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.выгрузитьКартуToolStripMenuItem.Text = "Выгрузить карту";
            this.выгрузитьКартуToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьКартуToolStripMenuItem_Click);
            // 
            // report
            // 
            this.report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётПоДисциплинамToolStripMenuItem,
            this.общийОтчётToolStripMenuItem});
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(51, 20);
            this.report.Text = "Отчёт";
            // 
            // отчётПоДисциплинамToolStripMenuItem
            // 
            this.отчётПоДисциплинамToolStripMenuItem.Name = "отчётПоДисциплинамToolStripMenuItem";
            this.отчётПоДисциплинамToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.отчётПоДисциплинамToolStripMenuItem.Text = "Отчёт по дисциплинам";
            this.отчётПоДисциплинамToolStripMenuItem.Click += new System.EventHandler(this.отчётПоДисциплинамToolStripMenuItem_Click);
            // 
            // общийОтчётToolStripMenuItem
            // 
            this.общийОтчётToolStripMenuItem.Name = "общийОтчётToolStripMenuItem";
            this.общийОтчётToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.общийОтчётToolStripMenuItem.Text = "Общий отчёт";
            this.общийОтчётToolStripMenuItem.Click += new System.EventHandler(this.общийОтчётToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this._filterLabel,
            this._filterBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 436);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _addButton
            // 
            this._addButton.Image = ((System.Drawing.Image)(resources.GetObject("_addButton.Image")));
            this._addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(79, 22);
            this._addButton.Text = "Добавить";
            this._addButton.Click += new System.EventHandler(this._addButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 22);
            this.toolStripButton1.Text = "Изменить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(111, 22);
            this.toolStripButton3.Text = "Экспорт в Excel";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // _filterLabel
            // 
            this._filterLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._filterLabel.Name = "_filterLabel";
            this._filterLabel.Size = new System.Drawing.Size(48, 22);
            this._filterLabel.Text = "Фильтр";
            // 
            // _filterBox
            // 
            this._filterBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._filterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._filterBox.Name = "_filterBox";
            this._filterBox.Size = new System.Drawing.Size(200, 25);
            this._filterBox.TextChanged += new System.EventHandler(this._filterBox_TextChanged);
            // 
            // _mainGridView
            // 
            this._mainGridView.AllowUserToAddRows = false;
            this._mainGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this._mainGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this._mainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._mainGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this._mainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainGridView.Location = new System.Drawing.Point(0, 24);
            this._mainGridView.Name = "_mainGridView";
            this._mainGridView.ReadOnly = true;
            this._mainGridView.RowTemplate.Height = 25;
            this._mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._mainGridView.Size = new System.Drawing.Size(609, 412);
            this._mainGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 461);
            this.Controls.Add(this._mainGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._toolStrip);
            this.MainMenuStrip = this._toolStrip;
            this.MinimumSize = new System.Drawing.Size(625, 500);
            this.Name = "MainForm";
            this.Text = "Рассчёт нагрузки";
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ClearSelectionHandler(object sender, EventArgs e)
        {
            if (_mainGridView.CurrentCell != null && _mainGridView.CurrentCell.RowIndex == -1)
            {
                _mainGridView.ClearSelection();
            }
        }

        private void Discipline_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StudyGroup_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private MenuStrip _toolStrip;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem Faculty;
        private ToolStripMenuItem Position;
        private ToolStripMenuItem StudyGroup;
        private ToolStripMenuItem Discipline;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem Lecturer;
        private ToolStripMenuItem WorkCard;
        private ToolStripMenuItem WorkLoadLine;
        private ToolStrip toolStrip1;
        private ToolStripButton _addButton;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem сохранитьБазуДанныхToolStripMenuItem;

        private void ColorClickHandler(object sender, EventArgs e)
        {
            _lastColorCommand?.UndoAction();
            _lastColorCommand = new ToolColorCommand((ToolStripMenuItem)sender);
            _lastColorCommand.MakeAction();
        }

        private void UpdateDataSource(object sender, EventArgs e)
        {
            var typedSender = (ToolStripMenuItem)sender;
            _currentController = _dataGridViewControllers[typedSender.Name];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = (_isFiltered) ? GetFilteredRecords() :
                _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = (typedSender.Name.Equals("WorkCard"));
            this.report.Visible = (typedSender.Name.Equals("WorkLoadLine"));
        }

        private ToolStripButton toolStripButton3;
        private ToolStripMenuItem выгрузитьКартуToolStripMenuItem;
        private DataGridView _mainGridView;
        private ToolStripLabel _filterLabel;
        private ToolStripTextBox _filterBox;
        private ToolStripMenuItem report;
        private ToolStripMenuItem отчётПоДисциплинамToolStripMenuItem;
        private ToolStripMenuItem общийОтчётToolStripMenuItem;
    }
}