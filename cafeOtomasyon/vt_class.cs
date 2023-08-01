using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cafeOtomasyon
{
    class vt_class
    {



        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        public void girisyap(string ad,string sifre,Form frm1)
        {
            command = new SqlCommand("Select *from kullanicilar where kullaniciadi='"+ad+"' and sifre='"+sifre+"'",connection);
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.gonderilenad = reader["kullaniciadi"].ToString();
                Form1.gelenyetki = reader["yetki"].ToString();
                anaekran anaekran = new anaekran();
                frm1.Hide();
                anaekran.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Şifre Bulunamadı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            connection.Close();
            command.Dispose();
        }

    }
}
