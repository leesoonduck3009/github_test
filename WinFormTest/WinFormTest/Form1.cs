using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "1";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxInput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "x";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            for(int i=0;i<input.Length;i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == 'x' || input[i] == '/')
                {
                    switch (input[i])
                    {
                        case '+':
                            string[] Tong = input.Split('+');
                            float tong = 0;
                            tong = float.Parse(Tong[0]) + float.Parse(Tong[1]);
                            textResult.Text = tong.ToString();
                            break;
                        case '-':
                            string[] Hieu = input.Split('-');
                            float hieu = 0;
                            hieu = float.Parse(Hieu[0]) - float.Parse(Hieu[1]);
                            textResult.Text = hieu.ToString();
                            break;
                        case 'x':
                            string[] Tich = input.Split('x');
                            float tich = 0;
                            tich = float.Parse(Tich[0]) * float.Parse(Tich[1]);
                            textResult.Text = tich.ToString();
                            break;
                        case '/':
                            string[] Thuong = input.Split('/');
                            float thuong = 0;
                            thuong = float.Parse(Thuong[0]) / float.Parse(Thuong[1]);
                            textResult.Text = thuong.ToString();
                            break;
                    }
                    break;
                }
                
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = null;
            textResult.Text = null;

        }
    }
}
