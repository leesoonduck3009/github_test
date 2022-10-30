using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Form1 : Form
    {
        Color color1 = Color.Black;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            color1 = color.Color;
            pictureBox1.BackColor = color1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Graphics graphics = flowLayoutPanelDraw.CreateGraphics();
            Rectangle rectangle = new Rectangle(100,100,100,100);
            Pen p = new Pen(color1);
            p.Width = 8;
            graphics.DrawRectangle(p, rectangle);

        }
    }
}
