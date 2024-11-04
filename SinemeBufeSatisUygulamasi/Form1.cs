using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemeBufeSatisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int misir, bilet, su, kola, toplam;
            misir = int.Parse(TxtMisir.Text);
            bilet = int.Parse(TxtBilet.Text);
            su = int.Parse(TxtSu.Text);
            kola = int.Parse(TxtKola.Text);

            toplam = misir * 50 + kola * 35 + su * 10 + bilet * 150;
            LblToplam.Text = toplam.ToString() +" TL";
            kasaTutar=kasaTutar+toplam;
            LblKasaTutar.Text = kasaTutar.ToString() + " TL";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtKola.Text = "";
            TxtSu.Text = "";
            TxtMisir.Text = "";
            TxtMisir.Focus();
        }
    }
}
