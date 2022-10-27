using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_ShutDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void TextBox1_KeyPress2(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.KeyPress += TextBox1_KeyPress2;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
           
            Timer timer = new Timer();
            timer.Interval = int.Parse(textBox1.Text)*1000;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            textBoxRemaintime.Text = textBox1.Text;
               int min = int.Parse(textBox1.Text) / 60;
            int sec = int.Parse(textBox1.Text) - min;
            
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;
            int time = int.Parse(textBoxRemaintime.Text);
            time--;
            if (time == 0)
                timer.Stop();
            textBoxRemaintime.Text = time.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            string filename="shutdown.exe";
            string agruement;
            if (radioButtonLogout.Checked == true)
            {
                agruement = "-l";
            }
            else if (radioButtonRestart.Checked == true)
            {
                agruement = "-r";
            }
            else
                agruement = "-s";
            ProcessStartInfo processStartInfo = new ProcessStartInfo(filename,agruement);
            Process.Start(processStartInfo);
            
            
            this.Close();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
