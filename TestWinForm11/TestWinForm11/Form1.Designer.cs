namespace TestWinForm11
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.panelSubmenu1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMain2 = new System.Windows.Forms.Button();
            this.panelSubmenu2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PnlMenu.SuspendLayout();
            this.panelSubmenu1.SuspendLayout();
            this.panelSubmenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PnlMenu.Controls.Add(this.panelSubmenu2);
            this.PnlMenu.Controls.Add(this.buttonMain2);
            this.PnlMenu.Controls.Add(this.panelSubmenu1);
            this.PnlMenu.Controls.Add(this.BtnMenu);
            this.PnlMenu.Controls.Add(this.panel1);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(135, 419);
            this.PnlMenu.TabIndex = 0;
            // 
            // panelSubmenu1
            // 
            this.panelSubmenu1.Controls.Add(this.button4);
            this.panelSubmenu1.Controls.Add(this.button3);
            this.panelSubmenu1.Controls.Add(this.button2);
            this.panelSubmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu1.Location = new System.Drawing.Point(0, 108);
            this.panelSubmenu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubmenu1.Name = "panelSubmenu1";
            this.panelSubmenu1.Size = new System.Drawing.Size(135, 85);
            this.panelSubmenu1.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenu.Location = new System.Drawing.Point(0, 77);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnMenu.Size = new System.Drawing.Size(135, 31);
            this.BtnMenu.TabIndex = 1;
            this.BtnMenu.Text = "Main";
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.UseWaitCursor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 77);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(135, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 56);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(135, 27);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // buttonMain2
            // 
            this.buttonMain2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMain2.Location = new System.Drawing.Point(0, 193);
            this.buttonMain2.Name = "buttonMain2";
            this.buttonMain2.Size = new System.Drawing.Size(135, 23);
            this.buttonMain2.TabIndex = 3;
            this.buttonMain2.Text = "Main2";
            this.buttonMain2.UseVisualStyleBackColor = true;
            this.buttonMain2.Click += new System.EventHandler(this.buttonMain2_Click);
            // 
            // panelSubmenu2
            // 
            this.panelSubmenu2.Controls.Add(this.button6);
            this.panelSubmenu2.Controls.Add(this.button5);
            this.panelSubmenu2.Controls.Add(this.button1);
            this.panelSubmenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenu2.Location = new System.Drawing.Point(0, 216);
            this.panelSubmenu2.Name = "panelSubmenu2";
            this.panelSubmenu2.Size = new System.Drawing.Size(135, 87);
            this.panelSubmenu2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(135, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(135, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 28);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(135, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 56);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(135, 28);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 419);
            this.Controls.Add(this.PnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlMenu.ResumeLayout(false);
            this.panelSubmenu1.ResumeLayout(false);
            this.panelSubmenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Panel panelSubmenu1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonMain2;
        private System.Windows.Forms.Panel panelSubmenu2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

