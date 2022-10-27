namespace GUI
{
    partial class FormSearchData
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
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelInnfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvg.Location = new System.Drawing.Point(222, 294);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(85, 33);
            this.labelAvg.TabIndex = 24;
            this.labelAvg.Text = "ĐTB: ";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(232, 221);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(75, 33);
            this.labelClass.TabIndex = 23;
            this.labelClass.Text = "Lớp: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(235, 149);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 33);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Tên: ";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(202, 95);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(105, 33);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "MSSV: ";
            // 
            // labelInnfo
            // 
            this.labelInnfo.AutoSize = true;
            this.labelInnfo.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInnfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInnfo.Location = new System.Drawing.Point(254, 36);
            this.labelInnfo.Name = "labelInnfo";
            this.labelInnfo.Size = new System.Drawing.Size(282, 38);
            this.labelInnfo.TabIndex = 17;
            this.labelInnfo.Text = "Thông tin sinh viên";
            // 
            // FormSearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelInnfo);
            this.Name = "FormSearchData";
            this.Text = "FormSearchData";
            this.Load += new System.EventHandler(this.FormSearchData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelInnfo;
    }
}