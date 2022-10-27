using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormUpdate : Form
    {
        string id;
        public FormUpdate()
        {
            InitializeComponent();
        }
        public FormUpdate(string ID): this()
        {
            id= ID;
            labelID.Text += ID;
        }
        

        private void FormUpdate_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           Student temp1= Student.FindStrStudent(id);
            Student temp = new Student(int.Parse(id), textBoxName.Text, float.Parse(textBoxAvg.Text), textBoxClass.Text);
            Student.UpdateStudent(temp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain fmain = new FormMain();
            this.Close();
            fmain.Show();
        }
    }
}
