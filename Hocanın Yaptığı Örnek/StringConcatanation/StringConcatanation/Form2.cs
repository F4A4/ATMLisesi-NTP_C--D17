using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringConcatanation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool SifreKontrol(string sifre)
        {
            bool durum = true;

            if (sifre.Length < 10)
            {
                durum = false;
            }

            if (char.IsDigit(sifre,0))
            {
                durum = false;
            }

            return durum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                bool sonuc = SifreKontrol(textBox1.Text);

                if (sonuc==true)
                {
                    label3.Text = "şifre ataması gerçekleştirildi.";
                    label3.ForeColor = Color.Green;
                }
                else
                {
                    label3.Text = "şifre kurallara uygun değil";
                    label3.ForeColor = Color.Red;
                }
            }
            else 
            {
                label3.Text = "iki şifre aynı değil.";
                label3.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(char.MinValue.ToString());
            textBox1.PasswordChar = char.MinValue;
            textBox2.PasswordChar = char.MinValue;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
