namespace TestDatabase1
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
            this.BttXuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.NM1_2 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NM1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BttXuat
            // 
            this.BttXuat.Location = new System.Drawing.Point(380, 306);
            this.BttXuat.Name = "BttXuat";
            this.BttXuat.Size = new System.Drawing.Size(75, 23);
            this.BttXuat.TabIndex = 0;
            this.BttXuat.Text = "Xuất";
            this.BttXuat.UseVisualStyleBackColor = true;
            this.BttXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "User name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(279, 225);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(279, 260);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(198, 20);
            this.textBoxSDT.TabIndex = 7;
            // 
            // NM1_2
            // 
            this.NM1_2.Location = new System.Drawing.Point(313, 308);
            this.NM1_2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NM1_2.Name = "NM1_2";
            this.NM1_2.Size = new System.Drawing.Size(61, 20);
            this.NM1_2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NM1_2);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BttXuat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NM1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.NumericUpDown NM1_2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

