﻿namespace UniversityWorkLoad.RecordForms
{
    partial class WorkCardRecordForm
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
            this._lecturerBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cancenButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._endTimePicker = new System.Windows.Forms.DateTimePicker();
            this._startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // _lecturerBox
            // 
            this._lecturerBox.FormattingEnabled = true;
            this._lecturerBox.Location = new System.Drawing.Point(121, 163);
            this._lecturerBox.Name = "_lecturerBox";
            this._lecturerBox.Size = new System.Drawing.Size(268, 23);
            this._lecturerBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Преподаватель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Конец учебного периода:";
            // 
            // _cancenButton
            // 
            this._cancenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancenButton.Location = new System.Drawing.Point(262, 192);
            this._cancenButton.Name = "_cancenButton";
            this._cancenButton.Size = new System.Drawing.Size(127, 23);
            this._cancenButton.TabIndex = 25;
            this._cancenButton.Text = "Отмена";
            this._cancenButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(121, 192);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(135, 23);
            this._okButton.TabIndex = 24;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Начало учебного периода:";
            // 
            // _endTimePicker
            // 
            this._endTimePicker.Location = new System.Drawing.Point(121, 119);
            this._endTimePicker.Name = "_endTimePicker";
            this._endTimePicker.Size = new System.Drawing.Size(268, 23);
            this._endTimePicker.TabIndex = 34;
            // 
            // _startTimePicker
            // 
            this._startTimePicker.Location = new System.Drawing.Point(121, 75);
            this._startTimePicker.Name = "_startTimePicker";
            this._startTimePicker.Size = new System.Drawing.Size(268, 23);
            this._startTimePicker.TabIndex = 35;
            // 
            // WorkCardRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 284);
            this.Controls.Add(this._startTimePicker);
            this.Controls.Add(this._endTimePicker);
            this.Controls.Add(this._lecturerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cancenButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label1);
            this.Name = "WorkCardRecordForm";
            this.Text = "WorkCardRecordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkCardRecordForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox _lecturerBox;
        private Label label3;
        private Label label2;
        private Button _cancenButton;
        private Button _okButton;
        private Label label1;
        private DateTimePicker _endTimePicker;
        private DateTimePicker _startTimePicker;
    }
}