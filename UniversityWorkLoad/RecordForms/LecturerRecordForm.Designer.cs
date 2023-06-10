namespace UniversityWorkLoad.RecordForms
{
    partial class LecturerRecordForm
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
            this._surnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._middleNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._facultyBox = new System.Windows.Forms.ComboBox();
            this._positionBox = new System.Windows.Forms.ComboBox();
            this._photoBox = new System.Windows.Forms.GroupBox();
            this._photoBitmap = new System.Windows.Forms.PictureBox();
            this._pathBox = new System.Windows.Forms.TextBox();
            this._loadPhotoButton = new System.Windows.Forms.Button();
            this._photoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._photoBitmap)).BeginInit();
            this.SuspendLayout();
            // 
            // _cancenButton
            // 
            this._cancenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancenButton.Location = new System.Drawing.Point(245, 304);
            this._cancenButton.Name = "_cancenButton";
            this._cancenButton.Size = new System.Drawing.Size(127, 23);
            this._cancenButton.TabIndex = 11;
            this._cancenButton.Text = "Отмена";
            this._cancenButton.UseVisualStyleBackColor = true;
            this._cancenButton.Click += new System.EventHandler(this._cancenButton_Click);
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(104, 304);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(135, 23);
            this._okButton.TabIndex = 10;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия:";
            // 
            // _surnameBox
            // 
            this._surnameBox.Location = new System.Drawing.Point(104, 71);
            this._surnameBox.Name = "_surnameBox";
            this._surnameBox.Size = new System.Drawing.Size(268, 23);
            this._surnameBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя:";
            // 
            // _nameBox
            // 
            this._nameBox.Location = new System.Drawing.Point(104, 116);
            this._nameBox.Name = "_nameBox";
            this._nameBox.Size = new System.Drawing.Size(268, 23);
            this._nameBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчество:";
            // 
            // _middleNameBox
            // 
            this._middleNameBox.Location = new System.Drawing.Point(104, 160);
            this._middleNameBox.Name = "_middleNameBox";
            this._middleNameBox.Size = new System.Drawing.Size(268, 23);
            this._middleNameBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Кафедра:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Должность:";
            // 
            // _facultyBox
            // 
            this._facultyBox.FormattingEnabled = true;
            this._facultyBox.Location = new System.Drawing.Point(104, 204);
            this._facultyBox.Name = "_facultyBox";
            this._facultyBox.Size = new System.Drawing.Size(268, 23);
            this._facultyBox.TabIndex = 20;
            // 
            // _positionBox
            // 
            this._positionBox.FormattingEnabled = true;
            this._positionBox.Location = new System.Drawing.Point(104, 246);
            this._positionBox.Name = "_positionBox";
            this._positionBox.Size = new System.Drawing.Size(268, 23);
            this._positionBox.TabIndex = 21;
            // 
            // _photoBox
            // 
            this._photoBox.Controls.Add(this._photoBitmap);
            this._photoBox.Location = new System.Drawing.Point(418, 71);
            this._photoBox.Name = "_photoBox";
            this._photoBox.Size = new System.Drawing.Size(270, 198);
            this._photoBox.TabIndex = 22;
            this._photoBox.TabStop = false;
            this._photoBox.Text = "Фото:";
            // 
            // _photoBitmap
            // 
            this._photoBitmap.Location = new System.Drawing.Point(6, 18);
            this._photoBitmap.Name = "_photoBitmap";
            this._photoBitmap.Size = new System.Drawing.Size(258, 174);
            this._photoBitmap.TabIndex = 0;
            this._photoBitmap.TabStop = false;
            // 
            // _pathBox
            // 
            this._pathBox.Location = new System.Drawing.Point(424, 275);
            this._pathBox.Name = "_pathBox";
            this._pathBox.Size = new System.Drawing.Size(258, 23);
            this._pathBox.TabIndex = 23;
            // 
            // _loadPhotoButton
            // 
            this._loadPhotoButton.Location = new System.Drawing.Point(424, 304);
            this._loadPhotoButton.Name = "_loadPhotoButton";
            this._loadPhotoButton.Size = new System.Drawing.Size(258, 23);
            this._loadPhotoButton.TabIndex = 24;
            this._loadPhotoButton.Text = "Выбрать фото";
            this._loadPhotoButton.UseVisualStyleBackColor = true;
            // 
            // LecturerRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._loadPhotoButton);
            this.Controls.Add(this._pathBox);
            this.Controls.Add(this._photoBox);
            this.Controls.Add(this._positionBox);
            this.Controls.Add(this._facultyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._middleNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._nameBox);
            this.Controls.Add(this._cancenButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._surnameBox);
            this.Name = "LecturerRecordForm";
            this.Text = "LecturerRecordForm";
            this._photoBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._photoBitmap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _cancenButton;
        private Button _okButton;
        private Label label1;
        private TextBox _surnameBox;
        private Label label2;
        private TextBox _nameBox;
        private Label label3;
        private TextBox _middleNameBox;
        private Label label4;
        private Label label5;
        private ComboBox _facultyBox;
        private ComboBox _positionBox;
        private GroupBox _photoBox;
        private PictureBox _photoBitmap;
        private TextBox _pathBox;
        private Button _loadPhotoButton;
    }
}