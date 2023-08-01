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
    public partial class Form1 : Form
    {
       


public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-HETC7ECE\SQLEXPRESS;Initial Catalog=cafeeotomasyonu;Integrated Security=True");


        public static string gonderilenad;
        public static string gelenyetki;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';

            label5.Text =  DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciad=txtKullaniciadi.Text;
            string sifre=txtSifre.Text;

            vt_class islem = new vt_class();
            islem.girisyap(kullaniciad,sifre,this);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("şifrenizi unuttuysanız: suveydaaltay3@gmail.com adresinden iletişime geçiniz!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
