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
    public partial class hastaEkle : Form
    {
        public hastaEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Proje_Hastane; user ID=postgres; password=12345");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into hasta (hasta_id,hasta_tc,hasta_ad,hasta_soyad,tel_no,dogum_yeri,eposta,hasta_teshis,kan_grubu,muayene_id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
            komut1.Parameters.AddWithValue("@p2", mskTc.Text);
            komut1.Parameters.AddWithValue("@p3", txtAd.Text);
            komut1.Parameters.AddWithValue("@p4", txtSoyad.Text);
            komut1.Parameters.AddWithValue("@p5", double.Parse(txtTelNo.Text));
            komut1.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut1.Parameters.AddWithValue("@p7", txtEposta.Text);
            komut1.Parameters.AddWithValue("@p8", txtTeshis.Text);
            komut1.Parameters.AddWithValue("@p9", comboBox2.Text);
            komut1.Parameters.AddWithValue("@p10", int.Parse(txtMuayeneId.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta Eklendi...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hastalistele()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void hastaEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from il", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "il_ad"; 
            comboBox1.ValueMember = "il_no";
            comboBox1.DataSource = dt;


            baglanti.Close();

            


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from hasta where hasta_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtAra.Text));
            komut2.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Hasta silindi...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update hasta set hasta_ad=@p2, hasta_soyad=@p3,tel_no=@p4,dogum_yeri=@p5,eposta=@p6,hasta_teshis=@p7,kan_grubu=@p8 where hasta_id=@p1",baglanti);
            komut3.Parameters.AddWithValue("@p2", txtAd.Text);
            komut3.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut3.Parameters.AddWithValue("@p4", double.Parse(txtTelNo.Text));
            komut3.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut3.Parameters.AddWithValue("@p6", txtEposta.Text);
            komut3.Parameters.AddWithValue("@p7", txtTeshis.Text);
            komut3.Parameters.AddWithValue("@p8", comboBox2.Text);
            komut3.Parameters.AddWithValue("@p1", int.Parse(txtID.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu1 = "Select * From hasta where hasta_id='" + txtAra.Text + "'";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
