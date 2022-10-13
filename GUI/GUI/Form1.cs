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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (Student.FindStudent(textBoxID.Text))
                MessageBox.Show("Đã tồn tại sinh viên này\n Vui lòng nhập lại!!", "Thông báo");
            else
            {
                string name = textBoxName.Text;
                int Id = int.Parse(textBoxID.Text);
                float Avg = float.Parse(textBoxAvg.Text);
                string Class = textBoxClass.Text;
                Student test = new Student(Id, name, Avg, Class);

                Student.SaveStudent(test);
                textBoxName.Text = "";
                textBoxID.Text = "";
                textBoxAvg.Text = "";
                textBoxClass.Text = "";
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearch fSearch =new FormSearch();
            fSearch.ShowDialog();
            this.Show();
        }

        private void labelInnfo_Click(object sender, EventArgs e)
        {

        }
    }
}
