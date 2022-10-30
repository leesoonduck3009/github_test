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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(con_string);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select MaNV,HoTen,SoDienThoai,NgayLV FROM NhanVien Where MaNV=@MaNV",con);   

            if(con.State==System.Data.ConnectionState.Open)
            {
                
            }    
        }
    }
}
