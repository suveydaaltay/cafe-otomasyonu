using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeOtomasyon
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
        }

        private void anaekran_Load(object sender, EventArgs e)
        {
            label1.Text +=Form1.gonderilenad;
            lblYetki.Text += Form1.gelenyetki;
            if (Form1.gelenyetki=="personel")
            {
                button3.Hide();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanicilar kullanicilar = new kullanicilar();
            this.Hide();
            kullanicilar.ShowDialog();
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            this.Hide();
            giris.ShowDialog();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunler urunler = new urunler();
            this.Hide();
            urunler.ShowDialog();
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carihesap gunlukhesap = new carihesap();
            this.Hide();
            gunlukhesap.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masalar masalar = new masalar();
            this.Hide();
            masalar.ShowDialog();
            Application.Exit();
        }
    }
}
