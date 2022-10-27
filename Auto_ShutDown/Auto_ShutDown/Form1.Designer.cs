namespace Auto_ShutDown
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
            this.radioButtonShutDown = new System.Windows.Forms.RadioButton();
            this.radioButtonRestart = new System.Windows.Forms.RadioButton();
            this.radioButtonLogout = new System.Windows.Forms.RadioButton();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.textBoxRemaintime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonShutDown
            // 
            this.radioButtonShutDown.AutoSize = true;
            this.radioButtonShutDown.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShutDown.Location = new System.Drawing.Point(270, 128);
            this.radioButtonShutDown.Name = "radioButtonShutDown";
            this.radioButtonShutDown.Size = new System.Drawing.Size(72, 18);
            this.radioButtonShutDown.TabIndex = 0;
            this.radioButtonShutDown.TabStop = true;
            this.radioButtonShutDown.Text = "ShutDown";
            this.radioButtonShutDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonRestart
            // 
            this.radioButtonRestart.AutoSize = true;
            this.radioButtonRestart.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRestart.Location = new System.Drawing.Point(386, 128);
            this.radioButtonRestart.Name = "radioButtonRestart";
            this.radioButtonRestart.Size = new System.Drawing.Size(58, 18);
            this.radioButtonRestart.TabIndex = 1;
            this.radioButtonRestart.TabStop = true;
            this.radioButtonRestart.Text = "Restart";
            this.radioButtonRestart.UseVisualStyleBackColor = true;
            // 
            // radioButtonLogout
            // 
            this.radioButtonLogout.AutoSize = true;
            this.radioButtonLogout.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLogout.Location = new System.Drawing.Point(270, 159);
            this.radioButtonLogout.Name = "radioButtonLogout";
            this.radioButtonLogout.Size = new System.Drawing.Size(63, 18);
            this.radioButtonLogout.TabIndex = 2;
            this.radioButtonLogout.TabStop = true;
            this.radioButtonLogout.Text = "Log Out";
            this.radioButtonLogout.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(154, 207);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(112, 23);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "Thời gian: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(260, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonOK.Location = new System.Drawing.Point(229, 259);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 29);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(148, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chức năng";
            // 
            // buttonCancle
            // 
            this.buttonCancle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonCancle.Location = new System.Drawing.Point(352, 259);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(95, 29);
            this.buttonCancle.TabIndex = 7;
            this.buttonCancle.Text = "Cancle";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // textBoxRemaintime
            // 
            this.textBoxRemaintime.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBoxRemaintime.Location = new System.Drawing.Point(270, 313);
            this.textBoxRemaintime.Name = "textBoxRemaintime";
            this.textBoxRemaintime.Size = new System.Drawing.Size(204, 30);
            this.textBoxRemaintime.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thời gian còn lại:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRemaintime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.radioButtonLogout);
            this.Controls.Add(this.radioButtonRestart);
            this.Controls.Add(this.radioButtonShutDown);
            this.Name = "Form1";
            this.Text = "Thời gian còn lại:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonShutDown;
        private System.Windows.Forms.RadioButton radioButtonRestart;
        private System.Windows.Forms.RadioButton radioButtonLogout;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.TextBox textBoxRemaintime;
        private System.Windows.Forms.Label label2;
    }
}

