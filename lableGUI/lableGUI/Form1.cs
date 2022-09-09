using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lableGUI
{

    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            LoadLb();
            
        }
        void LoadLb()
        {
            Label lb = new Label();
            lb.Text = "Hello Binh";
            lb.Location = new Point(30, 20);
            lb.Name = "Binh";
            lb.BackColor = Color.Wheat;
            lb.Click += Lb_Click;
            this.Controls.Add((Label)lb);
           
        }

        private void Lb_Click(object sender, EventArgs e)
        {
            Label temp= sender as Label;
            temp.Text = "Hello moi nguoi";
        }

        void LoadBtt()
        {
            Random random = new Random();   
            Button button=new Button();
            button.Text = "Nhap";
            button.Location = new Point(random.Next(0,this.Size.Width), random.Next(0,this.Size.Height));
            button.Click += Button_Click;
            this.Controls.Add((Button)button);
            i++;
        }

        void LoadTexBox()
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
           Button temp= sender as Button;
            MessageBox.Show(temp.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBtt();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
