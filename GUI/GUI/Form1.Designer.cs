namespace GUI
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInnfo
            // 
            this.labelInnfo.AutoSize = true;
            this.labelInnfo.Font = new System.Drawing.Font("Lucida Fax", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInnfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInnfo.Location = new System.Drawing.Point(249, 57);
            this.labelInnfo.Name = "labelInnfo";
            this.labelInnfo.Size = new System.Drawing.Size(396, 34);
            this.labelInnfo.TabIndex = 0;
            this.labelInnfo.Text = "Nhập thông tin sinh viên";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.textBox1.Location = new System.Drawing.Point(320, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 39);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.textBoxName.Location = new System.Drawing.Point(320, 187);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(277, 39);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.textBoxClass.Location = new System.Drawing.Point(320, 255);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(277, 39);
            this.textBoxClass.TabIndex = 3;
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.textBoxAvg.Location = new System.Drawing.Point(320, 328);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.Size = new System.Drawing.Size(277, 39);
            this.textBoxAvg.TabIndex = 4;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.labelID.Location = new System.Drawing.Point(216, 129);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(98, 32);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "MSSV:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.labelName.Location = new System.Drawing.Point(224, 190);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 32);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Tên: ";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.labelClass.Location = new System.Drawing.Point(226, 262);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(83, 32);
            this.labelClass.TabIndex = 7;
            this.labelClass.Text = "Lớp: ";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.labelAvg.Location = new System.Drawing.Point(226, 335);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(88, 32);
            this.labelAvg.TabIndex = 8;
            this.labelAvg.Text = "ĐTB: ";
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.buttonInput.Location = new System.Drawing.Point(374, 395);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(139, 65);
            this.buttonInput.TabIndex = 9;
            this.buttonInput.Text = "Nhập";
            this.buttonInput.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Lucida Fax", 16.2F);
            this.buttonSearch.Location = new System.Drawing.Point(716, 352);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(182, 150);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Đổi thông tin";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 502);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxAvg);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInnfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInnfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxAvg;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonSearch;
    }
}

