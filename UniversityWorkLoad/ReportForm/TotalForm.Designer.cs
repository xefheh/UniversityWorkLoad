namespace UniversityWorkLoad.ReportForm
{
    partial class TotalForm
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
            this._okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _startPicker
            // 
            this._startPicker.Location = new System.Drawing.Point(21, 27);
            this._startPicker.Name = "_startPicker";
            this._startPicker.Size = new System.Drawing.Size(200, 23);
            this._startPicker.TabIndex = 0;
            this._startPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // _endPicker
            // 
            this._endPicker.Location = new System.Drawing.Point(21, 74);
            this._endPicker.Name = "_endPicker";
            this._endPicker.Size = new System.Drawing.Size(200, 23);
            this._endPicker.TabIndex = 1;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(76, 103);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 2;
            this._okButton.Text = "ОК";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конец:";
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._endPicker);
            this.Controls.Add(this._startPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TotalForm";
            this.Text = "Общий отчёт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker _startPicker;
        private DateTimePicker _endPicker;
        private Button _okButton;
        private Label label1;
        private Label label2;
    }
}