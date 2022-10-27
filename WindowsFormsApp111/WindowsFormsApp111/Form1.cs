using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton(int i,int color)
        {
            Button num=new Button();
            Button deal= new Button();

            num.Location = new System.Drawing.Point(3, 3);
            num.Size = new System.Drawing.Size(27, 88);
            num.TabIndex = 0;
            num.Text = i.ToString();
            num.Dock = DockStyle.Fill;
            num.UseVisualStyleBackColor = true;
            deal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            deal.Dock = System.Windows.Forms.DockStyle.Fill;
            deal.Location = new System.Drawing.Point(36, 3);
            num.Click += Num_Click;
            deal.Size = new System.Drawing.Size(94, 88);
            deal.TabIndex = 1;
            deal.Text = "button2";
            deal.UseVisualStyleBackColor = false;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel.Controls.Add(num, 0, 0);
            tableLayoutPanel.Controls.Add(deal, 1, 0);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel.Name = "tableLayoutPanel1";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new System.Drawing.Size(133, 94);
            //tableLayoutPanel.TabIndex = 0;
            this.panelTemp.Controls.Add(tableLayoutPanel);
           

        }

        private void Num_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            MessageBox.Show(button.Text, "Show");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i=0;i<5;i++)
            {
                AddButton(rand.Next() % 100, 1);
                for (int j = 0; j < 5; j++)
                    AddButton(rand.Next()%100, 1);
                            }
        }
    }
}
