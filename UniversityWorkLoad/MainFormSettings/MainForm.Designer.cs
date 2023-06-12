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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._mainGridView = new System.Windows.Forms.DataGridView();
            this._toolStrip = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учебныеГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картыНагрузокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._addButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._mainGridView)).BeginInit();
            this._toolStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainGridView
            // 
            this._mainGridView.AllowUserToAddRows = false;
            this._mainGridView.AllowUserToDeleteRows = false;
            this._mainGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mainGridView.Location = new System.Drawing.Point(12, 39);
            this._mainGridView.Name = "_mainGridView";
            this._mainGridView.ReadOnly = true;
            this._mainGridView.RowTemplate.Height = 25;
            this._mainGridView.Size = new System.Drawing.Size(776, 383);
            this._mainGridView.TabIndex = 0;
            // 
            // _toolStrip
            // 
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.сохранитьБазуДанныхToolStripMenuItem,
            this.выгрузитьКартуToolStripMenuItem});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(800, 24);
            this._toolStrip.TabIndex = 1;
            this._toolStrip.Text = "_toolStrip";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кафедрыToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.учебныеГруппыToolStripMenuItem,
            this.дисциплиныToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // кафедрыToolStripMenuItem
            // 
            this.кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            this.кафедрыToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.кафедрыToolStripMenuItem.Text = "Кафедры";
            this.кафедрыToolStripMenuItem.Click += ColorClickHandler;
            this.кафедрыToolStripMenuItem.Click += UpdateToFaculties;
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += ColorClickHandler;
            this.должностиToolStripMenuItem.Click += UpdateToPositions;
            // 
            // учебныеГруппыToolStripMenuItem
            // 
            this.учебныеГруппыToolStripMenuItem.Name = "учебныеГруппыToolStripMenuItem";
            this.учебныеГруппыToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.учебныеГруппыToolStripMenuItem.Text = "Учебные группы";
            this.учебныеГруппыToolStripMenuItem.Click += ColorClickHandler;
            this.учебныеГруппыToolStripMenuItem.Click += UpdateToStudyGroups;
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины";
            this.дисциплиныToolStripMenuItem.Click += ColorClickHandler;
            this.дисциплиныToolStripMenuItem.Click += UpdateToDisciplines;
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.преподавателиToolStripMenuItem,
            this.картыНагрузокToolStripMenuItem,
            this.нагрузкиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += ColorClickHandler;
            this.преподавателиToolStripMenuItem.Click += UpdateToLecturers;
            // 
            // картыНагрузокToolStripMenuItem
            // 
            this.картыНагрузокToolStripMenuItem.Name = "картыНагрузокToolStripMenuItem";
            this.картыНагрузокToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.картыНагрузокToolStripMenuItem.Text = "Карточки";
            this.картыНагрузокToolStripMenuItem.Click += ColorClickHandler;
            this.картыНагрузокToolStripMenuItem.Click += UpdateToWorkCards;
            // 
            // нагрузкиToolStripMenuItem
            // 
            this.нагрузкиToolStripMenuItem.Name = "нагрузкиToolStripMenuItem";
            this.нагрузкиToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.нагрузкиToolStripMenuItem.Text = "Нагрузки";
            this.нагрузкиToolStripMenuItem.Click += ColorClickHandler;
            this.нагрузкиToolStripMenuItem.Click += UpdateToWorkLoadLine;
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this._mainGridView);
            this.Controls.Add(this._toolStrip);
            this.MainMenuStrip = this._toolStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this._mainGridView)).EndInit();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView _mainGridView;
        private MenuStrip _toolStrip;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem кафедрыToolStripMenuItem;
        private ToolStripMenuItem должностиToolStripMenuItem;
        private ToolStripMenuItem учебныеГруппыToolStripMenuItem;
        private ToolStripMenuItem дисциплиныToolStripMenuItem;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem преподавателиToolStripMenuItem;
        private ToolStripMenuItem картыНагрузокToolStripMenuItem;
        private ToolStripMenuItem нагрузкиToolStripMenuItem;
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

        private void UpdateToFaculties(object sender, EventArgs e)
        {
            _currentController = _dataGridViewControllers[typeof(Faculty)];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = false;
        }

        private void UpdateToLecturers(object sender, EventArgs e)
        {
            _currentController = _dataGridViewControllers[typeof(Lecturer)];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = false;
        }

        private void UpdateToDisciplines(object sender, EventArgs e)
        {
            _currentController = _dataGridViewControllers[typeof(Discipline)];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = false;
        }

        private void UpdateToPositions(object sender, EventArgs e)
        {
            _currentController = _dataGridViewControllers[typeof(Position)];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = false;
        }

        private void UpdateToStudyGroups(object sender, EventArgs e)
        {
            _currentController = _dataGridViewControllers[typeof(StudyGroup)];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = false;
        }

        private void UpdateToWorkCards(object sender, EventArgs e)
        {
            _currentController = _dataGridViewControllers[typeof(WorkCard)];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = true;
        }

        private void UpdateToWorkLoadLine(object sender, EventArgs e)
        {
            _currentController = _dataGridViewControllers[typeof(WorkLoadLine)];
            _mainGridView.DataSource = null;
            _mainGridView.DataSource = _currentController.GetBindingRecords();
            this.выгрузитьКартуToolStripMenuItem.Visible = false;
        }
        private ToolStripButton toolStripButton3;
        private ToolStripMenuItem выгрузитьКартуToolStripMenuItem;
    }
}