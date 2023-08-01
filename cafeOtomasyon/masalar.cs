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
    public partial class masalar : Form
    {
        public masalar()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");
        DataSet dataset = new DataSet();


        private void button1_Click(object sender, EventArgs e)
        {
            anaekran anaekran = new anaekran();
            this.Hide();
            anaekran.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masaekle masaekle = new masaekle();
            this.Hide();
            masaekle.ShowDialog();
            Application.Exit();
        }

        private void masalar_Load(object sender, EventArgs e)
        {
            label1.Text += Form1.gonderilenad;
            goster();
        }
        private void goster()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from masalar ", connection);
            adtr.Fill(dataset, "masalar");
            dataGridView1.DataSource = dataset.Tables["masalar"];
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
              //   dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            masahesabi2 masahesabi2 = new masahesabi2();
            masahesabi2.masaid = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            this.Hide();
            masahesabi2.ShowDialog();
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string tarih;

            tarih = DateTime.Now.ToLongDateString();

            SqlCommand komut = new SqlCommand("SELECT Count(tarih) FROM cariler WHERE tarih=@tarih", connection);
            //Komut nesnesine parametre ile kontrol edilecek veritabanin adini geciyoruz. 
            komut.Parameters.AddWithValue("@tarih", tarih);
            //Baglantiyi ac.
            connection.Open();
            //Executescalar ile sorgu sonucunda dönen degeri aliyoruz. Veritabanı varsa 1 yoksa 0 dönecektir.
            int sonuc = Convert.ToInt32( komut.ExecuteScalar());
            //işlem bitti. Baglantiyi kapatiyoruz.

            //Veritabanı var ise yapılacaklar
            if (sonuc != 0)
            {
                MessageBox.Show("Bu tarih var.");

               
                SqlCommand verioku = new SqlCommand("select * from cariler where tarih = '" + tarih + "'", connection);
                verioku.ExecuteNonQuery();
                SqlDataReader oku;
                oku = verioku.ExecuteReader();
                int tutartoplam=0;
                while (oku.Read())
                {
                    tutartoplam = Convert.ToInt32( oku["toplam"].ToString());

                }
                oku.Close();
                



                string toplam = dataGridView1.CurrentRow.Cells["tutar"].Value.ToString();
                tutartoplam += Convert.ToInt32(toplam);
                int masaid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                //Veritabanı yok ise yapılacaklar
                SqlCommand komut2 = new SqlCommand("update cariler set toplam=@toplam where tarih=@tarih", connection);
                komut2.Parameters.AddWithValue("@tarih", tarih);
                komut2.Parameters.AddWithValue("@toplam", tutartoplam.ToString());
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update masalar set tutar=@tutar where id=@id", connection);
                komut3.Parameters.AddWithValue("@tutar", "0");
                komut3.Parameters.AddWithValue("@id", masaid);
                komut3.ExecuteNonQuery();
                dataset.Tables["masalar"].Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from masalar ", connection);
                adtr.Fill(dataset, "masalar");
                dataGridView1.DataSource = dataset.Tables["masalar"];
                MessageBox.Show("varolan cari Ekleme Başarılı");
            }
            else
            {
                string toplam = dataGridView1.CurrentRow.Cells["tutar"].Value.ToString();
                int masaid= Convert.ToInt32( dataGridView1.CurrentRow.Cells["id"].Value.ToString());
                //Veritabanı yok ise yapılacaklar
                SqlCommand komut2 = new SqlCommand("insert into cariler(tarih,toplam) values(@tarih,@toplam) ", connection);
                komut2.Parameters.AddWithValue("@tarih", tarih);
                komut2.Parameters.AddWithValue("@toplam", toplam);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update masalar set tutar=@tutar where id=@id", connection);
                komut3.Parameters.AddWithValue("@tutar", "0");
                komut3.Parameters.AddWithValue("@id", masaid);
                komut3.ExecuteNonQuery();
                dataset.Tables["masalar"].Clear();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from masalar ", connection);
                adtr.Fill(dataset, "masalar");
                dataGridView1.DataSource = dataset.Tables["masalar"];
                MessageBox.Show("cari Ekleme Başarılı");
            }
            connection.Close();







        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasaAdi.Text = dataGridView1.CurrentRow.Cells["adi"].Value.ToString();
            txtMasaHesabi.Text = dataGridView1.CurrentRow.Cells["tutar"].Value.ToString();

            lblMasaid.Text = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("update masalar set adi=@adi, tutar=@tutar where id=@id", connection);
            komut.Parameters.AddWithValue("@adi", txtMasaAdi.Text);
            komut.Parameters.AddWithValue("@tutar", txtMasaHesabi.Text);
            komut.Parameters.AddWithValue("@id", lblMasaid.Text);
            komut.ExecuteNonQuery();
            connection.Close();
            dataset.Tables["masalar"].Clear();
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

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from masalar where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", connection);
            komut.ExecuteNonQuery();
            connection.Close();
            dataset.Tables["masalar"].Clear();
            goster();

            MessageBox.Show("Silme İşlemi Başarılı");
        }
    }
}
