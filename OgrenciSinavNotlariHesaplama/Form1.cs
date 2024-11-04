using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinavNotlariHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2,proje;
            double ortalama;

            ad=textBox1.Text;
            soyad=textBox2.Text;
            s1 = int.Parse(textBox3.Text);
            s2 = int.Parse(textBox4.Text);
            proje = int.Parse(textBox5.Text);
            ortalama = (s1+s2+proje)/3;
            listBox1.Items.Add(ad+ " "+soyad+ " Ortalama: "+ortalama);


        }
    }
}
