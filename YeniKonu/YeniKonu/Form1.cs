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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cümle=new string[50];
            string kelimeler = textBox1.Text;
            //cümle = kelimeler.Split(' ');
            //listBox1.Items.Add(kelimeler);
            for (int i = 0; i < cümle.Length; i++)
            {
                cümle = kelimeler.Split(' ');
                listBox1.Items.Add(cümle[i]);
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 A=new Form2();
            A.Show();
        }
    }
}
