namespace UniversityWorkLoad.RecordForms
{
    partial class FacultyRecordForm
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
            this._facultyNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._cancenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _facultyNameBox
            // 
            this._facultyNameBox.Location = new System.Drawing.Point(79, 38);
            this._facultyNameBox.Name = "_facultyNameBox";
            this._facultyNameBox.Size = new System.Drawing.Size(268, 23);
            this._facultyNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название кафедры:";
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(79, 67);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(135, 23);
            this._okButton.TabIndex = 2;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancenButton
            // 
            this._cancenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancenButton.Location = new System.Drawing.Point(220, 67);
            this._cancenButton.Name = "_cancenButton";
            this._cancenButton.Size = new System.Drawing.Size(127, 23);
            this._cancenButton.TabIndex = 3;
            this._cancenButton.Text = "Отмена";
            this._cancenButton.UseVisualStyleBackColor = true;
            // 
            // FacultyRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 121);
            this.Controls.Add(this._cancenButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._facultyNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FacultyRecordForm";
            this.Text = "FacultyRecordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacultyRecordForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _facultyNameBox;
        private Label label1;
        private Button _okButton;
        private Button _cancenButton;
    }
}