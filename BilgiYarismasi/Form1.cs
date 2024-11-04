using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sorunNo = 0, dogru=0, yanlis=0;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtcC.Enabled = false;
            BtnD.Enabled = false;

            label1.Text=BtnA.Text;
            if(label1.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSr_Click(object sender, EventArgs e)
        {
            sorunNo++;
            LblSoruNo.Text = sorunNo.ToString();
            if(sorunNo==1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtcC.Text = "1922";
                BtnD.Text = "1923";
                label1.Text = "1923";

            }

            if(sorunNo==2)
            {
                richTextBox1.Text = "Hangi şehir ege bölgemizde yer almaz";

                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtcC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label1.Text = "Balıkesir";

            }

            if (sorunNo == 3)
            {
                richTextBox1.Text = "Son kuşlar hangi yazarımıza aittir";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreyya";
                BtcC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri";
                label1.Text = "Sait Faik";
            }

            if(sorunNo == 4)
            {
                richTextBox1.Text = "2023-2024 Trendyol Süperlig Şampiyonu Hangi Takım Olmuştur";
                BtnA.Text = "Başakşehir";
                BtnB.Text = "Fenerbahçe";
                BtcC.Text = "Beşiktaş";
                BtnD.Text = "Galatasaray";
                label1.Text = "Galatasaray";
            }





        }
    }
}
