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
    public partial class urunler : Form
    {
        public urunler()
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

        private void urunler_Load(object sender, EventArgs e)
        {
            label1.Text += Form1.gonderilenad;
            goster();
        }


        private void goster()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urunler ", connection);
            adtr.Fill(dataset, "urunler");
            dataGridView1.DataSource = dataset.Tables["urunler"];
            connection.Close();
        }

        private void txtUrunFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void urunfiyat_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece rakam girişi sağlar!!
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunİsmi.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtUrunFiyati.Text = dataGridView1.CurrentRow.Cells["fiyati"].Value.ToString();

            lblid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("update urunler set urunadi=@urunadi, fiyati=@fiyati where id=@id", connection);
            komut.Parameters.AddWithValue("@urunadi", txtUrunİsmi.Text);
            komut.Parameters.AddWithValue("@fiyati", txtUrunFiyati.Text);
            komut.Parameters.AddWithValue("@id", lblid.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            dataset.Tables["urunler"].Clear();
            goster();
            MessageBox.Show("Güncelleme Başarılı");

            foreach(Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from urunler where id='"+ dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'",connection);
            komut.ExecuteNonQuery();
            connection.Close();
            dataset.Tables["urunler"].Clear();
            goster();

            MessageBox.Show("Silme İşlemi Başarılı");
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            urunekle urunekle = new urunekle();
            this.Hide();
            urunekle.ShowDialog();
            Application.Exit();
        }
    }
}
