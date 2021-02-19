using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneotomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtkullaniciadi.Text;
            string sifre = txtsifre.Text;

            if (kullaniciadi == "kullanici" && sifre == "sifre")
            {
                // MessageBox.Show("Doğru kullanici adi ve sifreyi girdiniz");
                this.Hide();
                panel ds = new panel();
                ds.Show();
            }
            else
            {
                MessageBox.Show("kullanici adi veya sifre yanlış");
            }
                }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
