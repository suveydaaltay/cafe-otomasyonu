using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeOtomasyon
{
    public partial class carihesap : Form
    {
        public carihesap()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");
        DataSet dataset = new DataSet();

        private void button6_Click(object sender, EventArgs e)
        {
            anaekran anaekran = new anaekran();
            this.Hide();
            anaekran.ShowDialog();
            Application.Exit();
        }

        private void carihesap_Load(object sender, EventArgs e)
        {
            goster();
        }
        private void goster()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from cariler ", connection);
            adtr.Fill(dataset, "cariler");
            dataGridView1.DataSource = dataset.Tables["cariler"];
            connection.Close();
        }
    }
}
