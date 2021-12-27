using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            #region kayit örneği
            //string ad = txtAd.Text;
            //string soyad = txtSoyad.Text;
            //int yas = Convert.ToInt32(txtYas.Text);
            //string cins = txtCins.Text;
            //string sehir = txtSehir.Text;
            //string ulke = txtUlke.Text;

            //Sonuc.Text = ad + " " + soyad + " " + yas.ToString() + " " + cins + " " + sehir + " " + ulke;

            #endregion
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            #region derece değiştirme
            //if (txtFahr.Text == "")
            //{
            //    double santigrat = Convert.ToDouble(txtSanti.Text);
            //    txtFahr.Text = Convert.ToString((santigrat * 1.8) + 32);
            //}
            //else
            //{
            //    double fahrenayt = Convert.ToDouble(txtFahr.Text);
            //    txtSanti.Text = Convert.ToString((fahrenayt - 32) / 1.8);
            //}
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region sayı kadar mesaj yazdırma
            //string yazi = txtYazi.Text;
            //int sayi = Convert.ToInt32(txtSayi.Text);

            //for (int i = 0; i < sayi; i++)
            //{
            //    MessageBox.Show(yazi);
            //}
            #endregion

        }
        
        private void btnArtir_Click(object sender, EventArgs e)
        {
            #region buton üzerindeki sayıyı artırma
            //int sayi = Convert.ToInt32(btnArtir.Text);
            //btnArtir.Text = (++sayi).ToString();
            #endregion

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int toplam = 0;
            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam += i;
            }
            txtSonuc.Text = Convert.ToString(toplam);
        }
    }
}
