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
    public partial class masahesabi2 : Form
    {
        public masahesabi2()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");
        DataSet dataset = new DataSet();
        public string masaid;
        private void masahesabi2_Load(object sender, EventArgs e)
        {
            label1.Text = masaid.ToString();
            label4.Text += Form1.gonderilenad;
            goster();
            connection.Open();
            SqlCommand verioku = new SqlCommand("select * from masalar where id = '" + masaid + "'", connection);
            verioku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = verioku.ExecuteReader();

            while (oku.Read())
            {

                lblMasaAdi.Text = oku["adi"].ToString();
                txtMasaHesabi.Text = oku["tutar"].ToString();

            }
            oku.Close();
            connection.Close();

        }

        private void goster()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urunler ", connection);
            adtr.Fill(dataset, "urunler");
            dataGridView1.DataSource = dataset.Tables["urunler"];
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            masalar masalar = new masalar();
            this.Hide();
            masalar.ShowDialog();
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunİsmi.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtUrunFiyati.Text = dataGridView1.CurrentRow.Cells["fiyati"].Value.ToString();

            lblid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("update masalar set tutar=@tutar where id=@id", connection);
            komut.Parameters.AddWithValue("@tutar", txtMasaHesabi.Text);
            komut.Parameters.AddWithValue("@id", label1.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            dataset.Tables["urunler"].Clear();
            goster();
            MessageBox.Show("Masa Hesabi Güncellendi");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int toplam = Convert.ToInt32(txtMasaHesabi.Text);
            toplam += Convert.ToInt32(txtUrunFiyati.Text);
            txtMasaHesabi.Text = toplam.ToString();

        }
    }
}
