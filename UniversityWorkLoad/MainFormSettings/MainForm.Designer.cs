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
            _mainGridView = new DataGridView();
            _toolStrip = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            кафедрыToolStripMenuItem = new ToolStripMenuItem();
            должностиToolStripMenuItem = new ToolStripMenuItem();
            учебныеГруппыToolStripMenuItem = new ToolStripMenuItem();
            дисциплиныToolStripMenuItem = new ToolStripMenuItem();
            таблицыToolStripMenuItem = new ToolStripMenuItem();
            преподавателиToolStripMenuItem = new ToolStripMenuItem();
            картыНагрузокToolStripMenuItem = new ToolStripMenuItem();
            нагрузкиToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            _addButton = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)_mainGridView).BeginInit();
            _toolStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // _mainGridView
            // 
            _mainGridView.AllowUserToAddRows = false;
            _mainGridView.AllowUserToDeleteRows = false;
            _mainGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _mainGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _mainGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _mainGridView.Location = new Point(12, 39);
            _mainGridView.Name = "_mainGridView";
            _mainGridView.ReadOnly = true;
            _mainGridView.RowTemplate.Height = 25;
            _mainGridView.Size = new Size(776, 383);
            _mainGridView.TabIndex = 0;
            // 
            // _toolStrip
            // 
            _toolStrip.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, таблицыToolStripMenuItem });
            _toolStrip.Location = new Point(0, 0);
            _toolStrip.Name = "_toolStrip";
            _toolStrip.Size = new Size(800, 24);
            _toolStrip.TabIndex = 1;
            _toolStrip.Text = "_toolStrip";
            _toolStrip.ItemClicked += _toolStrip_ItemClicked;
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { кафедрыToolStripMenuItem, должностиToolStripMenuItem, учебныеГруппыToolStripMenuItem, дисциплиныToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // кафедрыToolStripMenuItem
            // 
            кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            кафедрыToolStripMenuItem.Size = new Size(167, 22);
            кафедрыToolStripMenuItem.Text = "Кафедры";
            кафедрыToolStripMenuItem.Click += ColorClickHandler;
            // 
            // должностиToolStripMenuItem
            // 
            должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            должностиToolStripMenuItem.Size = new Size(167, 22);
            должностиToolStripMenuItem.Text = "Должности";
            должностиToolStripMenuItem.Click += ColorClickHandler;
            // 
            // учебныеГруппыToolStripMenuItem
            // 
            учебныеГруппыToolStripMenuItem.Name = "учебныеГруппыToolStripMenuItem";
            учебныеГруппыToolStripMenuItem.Size = new Size(167, 22);
            учебныеГруппыToolStripMenuItem.Text = "Учебные группы";
            учебныеГруппыToolStripMenuItem.Click += UpdateToStudyGroups;
            // 
            // дисциплиныToolStripMenuItem
            // 
            дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            дисциплиныToolStripMenuItem.Size = new Size(167, 22);
            дисциплиныToolStripMenuItem.Text = "Дисциплины";
            дисциплиныToolStripMenuItem.Click += ColorClickHandler;
            // 
            // таблицыToolStripMenuItem
            // 
            таблицыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { преподавателиToolStripMenuItem, картыНагрузокToolStripMenuItem, нагрузкиToolStripMenuItem });
            таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            таблицыToolStripMenuItem.Size = new Size(68, 20);
            таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // преподавателиToolStripMenuItem
            // 
            преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            преподавателиToolStripMenuItem.Size = new Size(159, 22);
            преподавателиToolStripMenuItem.Text = "Преподаватели";
            преподавателиToolStripMenuItem.Click += UpdateToLecturers;
            // 
            // картыНагрузокToolStripMenuItem
            // 
            картыНагрузокToolStripMenuItem.Name = "картыНагрузокToolStripMenuItem";
            картыНагрузокToolStripMenuItem.Size = new Size(159, 22);
            картыНагрузокToolStripMenuItem.Text = "Карточки";
            картыНагрузокToolStripMenuItem.Click += UpdateToWorkCards;
            // 
            // нагрузкиToolStripMenuItem
            // 
            нагрузкиToolStripMenuItem.Name = "нагрузкиToolStripMenuItem";
            нагрузкиToolStripMenuItem.Size = new Size(159, 22);
            нагрузкиToolStripMenuItem.Text = "Нагрузки";
            нагрузкиToolStripMenuItem.Click += UpdateToWorkLoadLine;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { _addButton, toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // _addButton
            // 
            _addButton.Image = (Image)resources.GetObject("_addButton.Image");
            _addButton.ImageTransparentColor = Color.Magenta;
            _addButton.Name = "_addButton";
            _addButton.Size = new Size(79, 22);
            _addButton.Text = "Добавить";
            _addButton.Click += _addButton_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(81, 22);
            toolStripButton1.Text = "Изменить";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(71, 22);
            toolStripButton2.Text = "Удалить";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(_mainGridView);
            Controls.Add(_toolStrip);
            MainMenuStrip = _toolStrip;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)_mainGridView).EndInit();
            _toolStrip.ResumeLayout(false);
            _toolStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}