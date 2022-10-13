namespace GUI
{
    partial class FormSearch
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInnfo
            // 
            this.labelInnfo.AutoSize = true;
            this.labelInnfo.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInnfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInnfo.Location = new System.Drawing.Point(225, 80);
            this.labelInnfo.Name = "labelInnfo";
            this.labelInnfo.Size = new System.Drawing.Size(373, 39);
            this.labelInnfo.TabIndex = 1;
            this.labelInnfo.Text = "Nhập MSSV cần thay đổi";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(264, 152);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(277, 39);
            this.textBoxID.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(326, 220);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 65);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Tìm ";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelInnfo);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInnfo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonSearch;
    }
}