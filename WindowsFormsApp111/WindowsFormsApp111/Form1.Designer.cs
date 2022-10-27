namespace WindowsFormsApp111
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
            this.flowLayoutPanelChuaButton = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTemp = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelChuaButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelChuaButton
            // 
            this.flowLayoutPanelChuaButton.AutoScroll = true;
            this.flowLayoutPanelChuaButton.Controls.Add(this.panelTemp);
            this.flowLayoutPanelChuaButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelChuaButton.Location = new System.Drawing.Point(232, 0);
            this.flowLayoutPanelChuaButton.Name = "flowLayoutPanelChuaButton";
            this.flowLayoutPanelChuaButton.Size = new System.Drawing.Size(624, 500);
            this.flowLayoutPanelChuaButton.TabIndex = 0;
            // 
            // panelTemp
            // 
            this.panelTemp.AutoScroll = true;
            this.panelTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelChuaButton.SetFlowBreak(this.panelTemp, true);
            this.panelTemp.Location = new System.Drawing.Point(3, 3);
            this.panelTemp.Name = "panelTemp";
            this.panelTemp.Size = new System.Drawing.Size(620, 219);
            this.panelTemp.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelChuaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanelChuaButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChuaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelTemp;
    }
}

