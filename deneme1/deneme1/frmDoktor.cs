using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1
{
    public partial class frmDoktor : Form
    {
        public frmDoktor()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Proje_Hastane; user ID=postgres; password=12345");

        private void Form2_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select bolum_adi from uzmanlik", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from doktorlistele()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into doktor (doktor_id,doktor_tc,doktor_ad,doktor_soyad,eposta,uzmanlik,gorev_yapilan_hastane,maas,nobet_no,personel_id,muayene_id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
            komut2.Parameters.AddWithValue("@p2", txtTC.Text);
            komut2.Parameters.AddWithValue("@p3", txtAd.Text);
            komut2.Parameters.AddWithValue("@p4", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p5", txtEposta.Text);
            komut2.Parameters.AddWithValue("@p6", int.Parse(txtUzmanlik.Text));
            komut2.Parameters.AddWithValue("@p7", txtHastane.Text);
            komut2.Parameters.AddWithValue("@p8", int.Parse(txtMaas.Text));
            komut2.Parameters.AddWithValue("@p9", int.Parse(txtNobetNo.Text));
            komut2.Parameters.AddWithValue("@p10", int.Parse(txtPersonelID.Text));
            komut2.Parameters.AddWithValue("@p11", int.Parse(txtMuayeneID.Text));
            komut2.ExecuteNonQuery();

            MessageBox.Show("Doktor Ekleme işlemi başarılı bir şekilde gerçekkeşti...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();

            

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu1 = "Select * From doktor where uzmanlik='" + txtAra.Text + "'";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            baglanti.Close();
        }

        private void cmbUzmanlik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from doktor where doktor_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtID2.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Doktor silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
