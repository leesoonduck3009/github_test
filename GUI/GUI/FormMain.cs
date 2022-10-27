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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInput fInput = new FormInput();
            fInput.ShowDialog();
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearch fSearch = new FormSearch();
            fSearch.ShowDialog();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdate fUpdate = new FormUpdate();
            fUpdate.ShowDialog();
            this.Close();
        }
    }
}
