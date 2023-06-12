namespace UniversityWorkLoad.RecordForms
{
    partial class WorkLoadLineRecordForm
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
            this._disciplineBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cancenButton = new System.Windows.Forms.Button();
            this._okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._groupBox = new System.Windows.Forms.ComboBox();
            this._cardBox = new System.Windows.Forms.ComboBox();
            this._lectureHours = new System.Windows.Forms.NumericUpDown();
            this._practiceHours = new System.Windows.Forms.NumericUpDown();
            this._otherHours = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._lectureHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._practiceHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._otherHours)).BeginInit();
            this.SuspendLayout();
            // 
            // _disciplineBox
            // 
            this._disciplineBox.FormattingEnabled = true;
            this._disciplineBox.Location = new System.Drawing.Point(36, 87);
            this._disciplineBox.Name = "_disciplineBox";
            this._disciplineBox.Size = new System.Drawing.Size(268, 23);
            this._disciplineBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Рабочая группа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Дисциплина:";
            // 
            // _cancenButton
            // 
            this._cancenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancenButton.Location = new System.Drawing.Point(184, 251);
            this._cancenButton.Name = "_cancenButton";
            this._cancenButton.Size = new System.Drawing.Size(127, 23);
            this._cancenButton.TabIndex = 38;
            this._cancenButton.Text = "Отмена";
            this._cancenButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(40, 251);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(135, 23);
            this._okButton.TabIndex = 37;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Карта нагрузки:";
            // 
            // _groupBox
            // 
            this._groupBox.FormattingEnabled = true;
            this._groupBox.Location = new System.Drawing.Point(36, 131);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(268, 23);
            this._groupBox.TabIndex = 43;
            // 
            // _cardBox
            // 
            this._cardBox.FormattingEnabled = true;
            this._cardBox.Location = new System.Drawing.Point(36, 42);
            this._cardBox.Name = "_cardBox";
            this._cardBox.Size = new System.Drawing.Size(268, 23);
            this._cardBox.TabIndex = 44;
            // 
            // _lectureHours
            // 
            this._lectureHours.Location = new System.Drawing.Point(191, 160);
            this._lectureHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._lectureHours.Name = "_lectureHours";
            this._lectureHours.Size = new System.Drawing.Size(120, 23);
            this._lectureHours.TabIndex = 45;
            this._lectureHours.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // _practiceHours
            // 
            this._practiceHours.Location = new System.Drawing.Point(191, 191);
            this._practiceHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._practiceHours.Name = "_practiceHours";
            this._practiceHours.Size = new System.Drawing.Size(120, 23);
            this._practiceHours.TabIndex = 46;
            // 
            // _otherHours
            // 
            this._otherHours.Location = new System.Drawing.Point(191, 218);
            this._otherHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._otherHours.Name = "_otherHours";
            this._otherHours.Size = new System.Drawing.Size(120, 23);
            this._otherHours.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Лекционные часы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Практические часы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "Прочие часы:";
            // 
            // WorkLoadLineRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._otherHours);
            this.Controls.Add(this._practiceHours);
            this.Controls.Add(this._lectureHours);
            this.Controls.Add(this._cardBox);
            this.Controls.Add(this._groupBox);
            this.Controls.Add(this._disciplineBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._cancenButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label1);
            this.Name = "WorkLoadLineRecordForm";
            this.Text = "WorkLoadLineRecordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkCardLineForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this._lectureHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._practiceHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._otherHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox _disciplineBox;
        private Label label3;
        private Label label2;
        private Button _cancenButton;
        private Button _okButton;
        private Label label1;
        private ComboBox _groupBox;
        private ComboBox _cardBox;
        private NumericUpDown _lectureHours;
        private NumericUpDown _practiceHours;
        private NumericUpDown _otherHours;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}