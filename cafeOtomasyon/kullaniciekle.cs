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
    public partial class kullaniciekle : Form
    {
        public kullaniciekle()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");


        private void kullaniciekle_Load(object sender, EventArgs e)
        {
            cBoxYetki.Items.Add("yönetici");

            cBoxYetki.Items.Add("personel");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicilar kullanicilar = new kullanicilar();
            this.Hide();
            kullanicilar.ShowDialog();
            Application.Exit();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("insert into kullanicilar(kullaniciadi,sifre,yetki) values(@kullaniciadi,@sifre,@yetki) ", connection);
            komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@yetki", cBoxYetki.SelectedItem.ToString());
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
