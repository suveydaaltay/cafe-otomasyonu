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
    public partial class urunekle : Form
    {
        public urunekle()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            urunler urunler = new urunler();
            this.Hide();
            urunler.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into urunler(urunadi,fiyati) values(@urunadi,@fiyati) ",connection);
            komut.Parameters.AddWithValue("@urunadi", txtUrunisim.Text);
            komut.Parameters.AddWithValue("@fiyati", txtUrunfiyat.Text);
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
