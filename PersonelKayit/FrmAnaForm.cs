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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-83L42UFV\\SQLEXPRESS;Initial Catalog=PersonelVeriTabaniDb;Integrated Security=True;Encrypt=False");
        
        void temizle()
        {
            TxtPersonelid.Text = "";
            TxtPersonelAd.Text = "";
            TxtPersonelSoyad.Text = "";
            TxtPersonelSoyad.Text = "";
            MskMaas.Text = "";
            CmbSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked=false; 
            TxtPersonelAd.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDbDataSet.TblPersonel' table. You can move, or remove it, as needed.
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;
            TxtPersonelid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtPersonelAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtPersonelSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tblPersonelTableAdapter.Fill(this.personelVeriTabaniDbDataSet.TblPersonel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kmt = new SqlCommand("insert into TblPersonel (PersonelAd,PersonelSoyad,PersonelSehir,PersonelMaas,PersonelMeslek,PersonelDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            kmt.Parameters.Add("@p1", TxtPersonelAd.Text);
            kmt.Parameters.Add("@p2", TxtPersonelSoyad.Text);
            kmt.Parameters.Add("@p3", CmbSehir.Text);
            kmt.Parameters.Add("@p4", MskMaas.Text);
            kmt.Parameters.Add("@p5", TxtMeslek.Text);
            kmt.Parameters.Add("@p6", label8.Text);


           
            kmt.ExecuteNonQuery();

            baglanti.Close();   
            MessageBox.Show("Personel Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            };    
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                radioButton1.Checked= true;
            }
            if(label8.Text == "False")
            {
                radioButton2.Checked= true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from TblPersonel where Personelid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", TxtPersonelid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update TblPersonel Set PersonelAd=@a1,PersonelSoyad=@a2,PersonelSehir=@a3 ,PersonelMaas=@a4,PersonelDurum=@a5,PersonelMeslek=@a6 where Personelid=@a7",baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", TxtPersonelAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", TxtPersonelSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", CmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", MskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", TxtPersonelid.Text);
            komutguncelle.ExecuteNonQuery();
      
            baglanti.Close();

            MessageBox.Show("Bilgi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void Btnista_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();

        }

        private void BtnGra_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmgrk = new FrmGrafikler();
            frmgrk.Show();
        }
    }
}
