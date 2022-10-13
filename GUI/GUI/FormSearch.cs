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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(Student.FindStudent(textBoxID.Text))
            {
                this.Hide();
                FormUpdate fUpdate = new FormUpdate(textBoxID.Text);
                fUpdate.ShowDialog();
                //fUpdate.Close();
            }
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
