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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-83L42UFV\\SQLEXPRESS;Initial Catalog=PersonelVeriTabaniDb;Integrated Security=True;Encrypt=False");

        private void chart1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutg1 = new SqlCommand("Select PersonelSehir, Count(*) from TblPersonel Group By PersonelSehir",baglanti);
            SqlDataReader reader = komutg1.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(reader[0], reader[1]);
            }


            baglanti.Close();   
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutg2 = new SqlCommand("Select PersonelMeslek,Avg(PersonelMaas) from TblPersonel Group By PersonelMeslek ", baglanti);
            SqlDataReader reader2 = komutg2.ExecuteReader();
            while (reader2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(reader2[0], reader2[1]);
            }

            baglanti.Close();
        }
    }
}
