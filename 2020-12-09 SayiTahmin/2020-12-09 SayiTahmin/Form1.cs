using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_12_09_SayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        private void btnUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(1, 11);
            MessageBox.Show("Sayı hafızaya atıldı.");
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (sayi == 0)
            {
                MessageBox.Show("Önce sayı üretmelisiniz!");
                return;//alttaki satırları çalıştırmadan yaşam alanının dışına çıkar.
            }

            int kalanHak = Convert.ToInt32(lblKalanHak.Text);
            if (kalanHak == 0)
            {
                MessageBox.Show("Canlarınız bitti tekrar görüşmek üzere..");

                //this.Close(); // bu formu kapatır.

                Application.Exit(); // bütün uygulamayı kapatır - tüm formlarıyla birlikte

                //btnTahminEt.Enabled = false; // buton tıklanamaz hale gelsin
                //return;
            }
            else
            {
                lblKalanHak.Text = (kalanHak - 1).ToString();
            }            

            if (txtTahmin.Text == "")
            {
                MessageBox.Show("Tahmininizi girin!");
                return;
            }

            if (txtTahmin.Text == sayi.ToString())
            {
                MessageBox.Show("Tebrikler bildiniz!");
            }
            else
            {
                MessageBox.Show("üzgünüm tekrar deneyin.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
