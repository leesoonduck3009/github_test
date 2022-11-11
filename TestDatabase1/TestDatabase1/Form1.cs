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
        public string con = "Data Source=LAPTOP-8BAO71EG\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ACCOUNT WHERE Id = " + NM1_2.Value;
            DataTable dt = LoadAccountList(query);
            if (dt.Rows.Count > 0)
            {
                this.textBoxName.Text = dt.Rows[0]["UserName"].ToString();
                this.textBoxSDT.Text = dt.Rows[0]["DisplayName"].ToString();
            }
        }
        DataTable LoadAccountList(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(con))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
               
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
