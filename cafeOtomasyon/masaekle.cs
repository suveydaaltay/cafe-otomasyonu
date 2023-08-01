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
    public partial class masaekle : Form
    {
        public masaekle()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            masalar masalar = new masalar();
            this.Hide();
            masalar.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar = 0;

            connection.Open();
            SqlCommand komut = new SqlCommand("insert into masalar(adi,tutar) values(@adi,@tutar) ", connection);
            komut.Parameters.AddWithValue("@adi", txtMasaAdi.Text);
            komut.Parameters.AddWithValue("@tutar", tutar);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ekleme Başarılı");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
