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
            _facultyNameBox = new TextBox();
            label1 = new Label();
            _okButton = new Button();
            _cancenButton = new Button();
            SuspendLayout();
            // 
            // _facultyNameBox
            // 
            _facultyNameBox.Location = new Point(79, 38);
            _facultyNameBox.Name = "_facultyNameBox";
            _facultyNameBox.Size = new Size(268, 23);
            _facultyNameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 20);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Название кафедры:";
            // 
            // _okButton
            // 
            _okButton.DialogResult = DialogResult.OK;
            _okButton.Location = new Point(79, 67);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(135, 23);
            _okButton.TabIndex = 2;
            _okButton.Text = "OK";
            _okButton.UseVisualStyleBackColor = true;
            // 
            // _cancenButton
            // 
            _cancenButton.DialogResult = DialogResult.Cancel;
            _cancenButton.Location = new Point(220, 67);
            _cancenButton.Name = "_cancenButton";
            _cancenButton.Size = new Size(127, 23);
            _cancenButton.TabIndex = 3;
            _cancenButton.Text = "Отмена";
            _cancenButton.UseVisualStyleBackColor = true;
            // 
            // FacultyRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 121);
            Controls.Add(_cancenButton);
            Controls.Add(_okButton);
            Controls.Add(label1);
            Controls.Add(_facultyNameBox);
            Name = "FacultyRecordForm";
            Text = "FacultyRecordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _facultyNameBox;
        private Label label1;
        private Button _okButton;
        private Button _cancenButton;
    }
}