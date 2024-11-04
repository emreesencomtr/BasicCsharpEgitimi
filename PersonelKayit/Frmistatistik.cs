using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PersonelKayit
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-83L42UFV\\SQLEXPRESS;Initial Catalog=PersonelVeriTabaniDb;Integrated Security=True;Encrypt=False");
        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1=new SqlCommand("Select Count(*) from TblPersonel",baglanti);
            SqlDataReader dr1= komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonelSayisi.Text = dr1[0].ToString();
            }

            baglanti.Close();

            //Evli Personel Sayısı
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) from TblPersonel where PersonelDurum=1",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonel.Text= dr2[0].ToString();
            }

            baglanti.Close();

            //Bekar Personel Sayısı

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) from TblPersonel where PersonelDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();


            //Şehir Sayısı

            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("select count(distinct(PersonelSehir)) from TblPersonel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehirSayisi.Text = dr4[0].ToString();    
            }

            baglanti.Close();

            //Toplam Maaş

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select Sum(PersonelMaas) from TblPersonel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblToplamMaas.Text = dr5[0].ToString() + " TL";
            }
               

            baglanti.Close();


            //Ortalama Maaş
            baglanti.Open ();
            SqlCommand komut6 = new SqlCommand("Select Avg(PersonelMaas) from TblPersonel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalama.Text = dr6[0].ToString() + " TL";
            }
            baglanti.Close();
        }
    }
}
