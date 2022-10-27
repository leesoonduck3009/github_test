using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TestDatabase1
{
    public partial class Form1 : Form
    {
        public string con_string = "Data Source=LAPTOP-8BAO71EG\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
    }
}
