using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formsilk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double yil = Convert.ToDouble(dYili.Text);
            double yas = DateTime.Now.Year - yil;
            double kilo = Convert.ToDouble(txtKilo.Text);
            double boy = Convert.ToDouble(txtBoy.Text);
            string cinsiyet = txtCins.Text;
            double k;
            

            if (cinsiyet=="e" || cinsiyet=="E")
            {
                k = 0.9;
            }
            else if (cinsiyet == "k" || cinsiyet == "K")
            {
                 k = 0.8;
            }
            else
            {
                 k = 0;

            }

            double ideal = (boy - 100 + yas / 10) * k;

            Sonuc.Text = ideal.ToString();

        }
    }
}
