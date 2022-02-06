using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1___kullanici_biilgilerini_yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            float gelir ;
            gelir = Convert.ToSingle((rdbCalisiyor.Checked) ? txtGelir.Text: "0");
            string calismaDurumu =  rdbCalisiyor.Checked ? "Calisiyor" : "Calismiyor";           
                MessageBox.Show("ad ; " + ad +
                            "\nsoyad ; " + soyad + 
                            "\nbakiye ; " + gelir + 
                            "\ncalisma durumu ; " + calismaDurumu);

        }

        private void rdbCalismiyor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCalismiyor.Checked)
            {
                txtGelir.Text = "";
                txtGelir.Enabled = false;
            }
            else
            {
                txtGelir.Enabled = true;
            }
        }

       
    }
}
