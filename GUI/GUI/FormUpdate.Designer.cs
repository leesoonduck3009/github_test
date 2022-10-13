namespace GUI
{
    partial class FormUpdate
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
            this.labelInnfo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInnfo
            // 
            this.labelInnfo.AutoSize = true;
            this.labelInnfo.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInnfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInnfo.Location = new System.Drawing.Point(248, 76);
            this.labelInnfo.Name = "labelInnfo";
            this.labelInnfo.Size = new System.Drawing.Size(400, 38);
            this.labelInnfo.TabIndex = 2;
            this.labelInnfo.Text = "Nhập thông tin cần thay đổi";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(249, 135);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(105, 33);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "MSSV: ";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(398, 394);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(139, 65);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvg.Location = new System.Drawing.Point(250, 334);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(85, 33);
            this.labelAvg.TabIndex = 15;
            this.labelAvg.Text = "ĐTB: ";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(250, 261);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(75, 33);
            this.labelClass.TabIndex = 14;
            this.labelClass.Text = "Lớp: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(248, 189);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 33);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Tên: ";
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvg.Location = new System.Drawing.Point(344, 327);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.Size = new System.Drawing.Size(277, 39);
            this.textBoxAvg.TabIndex = 12;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClass.Location = new System.Drawing.Point(344, 254);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(277, 39);
            this.textBoxClass.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(344, 186);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(277, 39);
            this.textBoxName.TabIndex = 10;
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 535);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAvg);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelInnfo);
            this.Name = "FormUpdate";
            this.Text = "FormUpdate";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInnfo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAvg;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxName;
    }
}