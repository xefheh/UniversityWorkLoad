namespace UniversityWorkLoad.RecordForms
{
    partial class DisciplineRecordForm
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
            this._cancenButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._disciplineBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _cancenButton
            // 
            this._cancenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancenButton.Location = new System.Drawing.Point(153, 65);
            this._cancenButton.Name = "_cancenButton";
            this._cancenButton.Size = new System.Drawing.Size(127, 23);
            this._cancenButton.TabIndex = 7;
            this._cancenButton.Text = "Отмена";
            this._cancenButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(12, 65);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(135, 23);
            this._okButton.TabIndex = 6;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название дисциплины:";
            // 
            // _disciplineBox
            // 
            this._disciplineBox.Location = new System.Drawing.Point(12, 36);
            this._disciplineBox.Name = "_disciplineBox";
            this._disciplineBox.Size = new System.Drawing.Size(268, 23);
            this._disciplineBox.TabIndex = 4;
            // 
            // DisciplineRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 120);
            this.Controls.Add(this._cancenButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._disciplineBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DisciplineRecordForm";
            this.Text = "DisciplineRecordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisciplineRecordForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _cancenButton;
        private Button _okButton;
        private Label label1;
        private TextBox _disciplineBox;
    }
}