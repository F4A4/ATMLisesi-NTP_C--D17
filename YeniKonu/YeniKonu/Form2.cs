using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YeniKonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kontrol = sifre(textBox1.Text);
        }
        public string sifre(string sifre1)
        {
            
            if (textBox1.Text == textBox2.Text)
            {
                if (10<sifre1.Length)
                {
                    if (sifre1.StartsWith("0") || sifre1.StartsWith("1") || sifre1.StartsWith("2") || sifre1.StartsWith("3") || sifre1.StartsWith("4") || sifre1.StartsWith("5") || sifre1.StartsWith("6") || sifre1.StartsWith("7") || sifre1.StartsWith("8") || sifre1.StartsWith("9"))
                    {
                         label3.Text = "HATA VAR!! İLK OLARAK SAYI GİRMEMELİSİNİZ";
                         label3.ForeColor = Color.Red;
                    }
                    else
                    {
                         label3.Text = "HATA YOK";
                         label3.ForeColor = Color.Green;
                    }
                }
                else
                {
                    label3.Text = "HATA VAR!!! KARAKTER KULLANIMINIZ 10 DAN BÜYÜK OLMALIDIR";
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                label3.Text = "HATA VAR!!!! ŞİFRE ONAYINI KONTROL EDİNİZ";
                label3.ForeColor = Color.Red;
            }

            return sifre1;
        }

     }
}
