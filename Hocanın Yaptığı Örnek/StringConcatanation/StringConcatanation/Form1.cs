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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] kelimeler = new string[10];
            string isimler = "meram ticaret meslek lisesi";
            kelimeler = isimler.Split(',');
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kelimeler = textBox1.Text.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
            {
                listBox1.Items.Add(kelimeler[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Text = "Şifre Değiştir";
            frm2.Show();
        }
    }
}
