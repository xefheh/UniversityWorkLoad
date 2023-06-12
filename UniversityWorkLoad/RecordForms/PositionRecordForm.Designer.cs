namespace UniversityWorkLoad.RecordForms
{
    partial class PositionRecordForm
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
            this._positionNameBox = new System.Windows.Forms.TextBox();
            this._upNumeric = new System.Windows.Forms.NumericUpDown();
            this._downNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._upNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._downNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // _cancenButton
            // 
            this._cancenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancenButton.Location = new System.Drawing.Point(173, 143);
            this._cancenButton.Name = "_cancenButton";
            this._cancenButton.Size = new System.Drawing.Size(127, 23);
            this._cancenButton.TabIndex = 7;
            this._cancenButton.Text = "Отмена";
            this._cancenButton.UseVisualStyleBackColor = true;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(32, 143);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(135, 23);
            this._okButton.TabIndex = 6;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название должности:";
            // 
            // _positionNameBox
            // 
            this._positionNameBox.Location = new System.Drawing.Point(32, 51);
            this._positionNameBox.Name = "_positionNameBox";
            this._positionNameBox.Size = new System.Drawing.Size(268, 23);
            this._positionNameBox.TabIndex = 4;
            // 
            // _upNumeric
            // 
            this._upNumeric.Location = new System.Drawing.Point(180, 109);
            this._upNumeric.Name = "_upNumeric";
            this._upNumeric.Size = new System.Drawing.Size(120, 23);
            this._upNumeric.TabIndex = 8;
            // 
            // _downNumeric
            // 
            this._downNumeric.Location = new System.Drawing.Point(180, 80);
            this._downNumeric.Name = "_downNumeric";
            this._downNumeric.Size = new System.Drawing.Size(120, 23);
            this._downNumeric.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Нижний предел:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Верхний предел:";
            // 
            // PositionRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._downNumeric);
            this.Controls.Add(this._upNumeric);
            this.Controls.Add(this._cancenButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._positionNameBox);
            this.Name = "PositionRecordForm";
            this.Text = "PositionRecordForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionRecordForm_FormClosing);
            this.Load += new System.EventHandler(this.PositionRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._upNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._downNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _cancenButton;
        private Button _okButton;
        private Label label1;
        private TextBox _positionNameBox;
        private NumericUpDown _upNumeric;
        private NumericUpDown _downNumeric;
        private Label label2;
        private Label label3;
    }
}