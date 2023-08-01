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
    public partial class kullanicilar : Form
    {
        public kullanicilar()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");
        DataSet dataset = new DataSet();

        private void kullanicilar_Load(object sender, EventArgs e)
        {
            label1.Text +=Form1.gonderilenad;
            goster();
            cboxYetki.Items.Add("yönetici");

            cboxYetki.Items.Add("personel");
        }

        private void goster()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanicilar ", connection);
            adtr.Fill(dataset, "kullanicilar");
            dataGridView1.DataSource = dataset.Tables["kullanicilar"];
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            anaekran anaekran = new anaekran();
            this.Hide();
            anaekran.ShowDialog();
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string yetki;
            
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells["kullaniciadi"].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells["sifre"].Value.ToString();
            yetki= dataGridView1.CurrentRow.Cells["yetki"].Value.ToString();
            if (yetki=="yönetici")
            {
                cboxYetki.SelectedIndex = 0;
            }
            else
            {
                cboxYetki.SelectedIndex = 1;
            }
            lblid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string yetki = cboxYetki.SelectedItem.ToString();
            connection.Open();
            SqlCommand komut = new SqlCommand("update kullanicilar set kullaniciadi=@kullaniciadi, sifre=@sifre, yetki=@yetki where id=@id", connection);
            komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@yetki", yetki);
            komut.Parameters.AddWithValue("@id", lblid.Text);

            
            komut.ExecuteNonQuery();
            connection.Close();
            dataset.Tables["kullanicilar"].Clear();
            goster();
            MessageBox.Show("Güncelleme Başarılı");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from kullanicilar where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", connection);

            
            komut.ExecuteNonQuery();
            connection.Close();
            dataset.Tables["kullanicilar"].Clear();
            goster();

            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullaniciekle yk = new kullaniciekle();
            this.Hide();
            yk.ShowDialog();
            Application.Exit();
        }
    }
}
