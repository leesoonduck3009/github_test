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
    public partial class FormSearchData : Form
    {
        string mssv;
        public FormSearchData()
        {
            InitializeComponent();
        }
        public FormSearchData(string MSSV): this()
        {
            mssv = MSSV;
        }
        private void FormSearchData_Load(object sender, EventArgs e)
        {
           Student a= Student.FindStrStudent(mssv);
            labelID.Text = "MSSV: " + a.Id.ToString();
            labelName.Text = "Tên: " + a.Name;
            labelClass.Text = "Lớp: " + a.Class;
            labelAvg.Text = "ĐTB: " + a.Avg.ToString();
        }
    }
}
