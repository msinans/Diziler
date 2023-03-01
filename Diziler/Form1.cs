using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "Ali", "Mehmet", "Ahmet", "Can", "Alper" };
            label1.Text = kisiler[4];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, };
            label2.Text = sayilar[4].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] ondalik = { 0.1, 0.2, 0.3, 1.20, 0.555 };
            label3.Text = ondalik[1].ToString("0.000");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] harfler = { 'a', 'b', 'c', 'd' };
            label4.Text = harfler[0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] adlar = { "Ali", "Veli", "Murat" };
            for (int i = 0; i < adlar.Length; i++)
            {
                listBox1.Items.Add(adlar[i]);
            }

        }
    }
}
