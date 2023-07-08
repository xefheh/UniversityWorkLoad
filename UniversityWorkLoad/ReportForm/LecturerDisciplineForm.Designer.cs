namespace UniversityWorkLoad.ReportForm
{
    partial class LecturerDisciplineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._startPicker = new System.Windows.Forms.DateTimePicker();
            this._endPicker = new System.Windows.Forms.DateTimePicker();
            this._lecturerBox = new System.Windows.Forms.ComboBox();
            this._buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _startPicker
            // 
            this._startPicker.Location = new System.Drawing.Point(29, 26);
            this._startPicker.Name = "_startPicker";
            this._startPicker.Size = new System.Drawing.Size(200, 23);
            this._startPicker.TabIndex = 0;
            // 
            // _endPicker
            // 
            this._endPicker.Location = new System.Drawing.Point(235, 26);
            this._endPicker.Name = "_endPicker";
            this._endPicker.Size = new System.Drawing.Size(200, 23);
            this._endPicker.TabIndex = 1;
            // 
            // _lecturerBox
            // 
            this._lecturerBox.FormattingEnabled = true;
            this._lecturerBox.Location = new System.Drawing.Point(29, 68);
            this._lecturerBox.Name = "_lecturerBox";
            this._lecturerBox.Size = new System.Drawing.Size(406, 23);
            this._lecturerBox.TabIndex = 2;
            // 
            // _buttonOk
            // 
            this._buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._buttonOk.Location = new System.Drawing.Point(29, 136);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(406, 23);
            this._buttonOk.TabIndex = 3;
            this._buttonOk.Text = "ОК";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this._buttonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начало:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конец:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Лектор:";
            // 
            // LecturerDisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._lecturerBox);
            this.Controls.Add(this._endPicker);
            this.Controls.Add(this._startPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LecturerDisciplineForm";
            this.Text = "Отчёт по дисциплинам";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker _startPicker;
        private DateTimePicker _endPicker;
        private ComboBox _lecturerBox;
        private Button _buttonOk;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}