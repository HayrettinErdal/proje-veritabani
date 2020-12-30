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
    public partial class Randevu : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Proje_Hastane; user ID=postgres; password=12345");

        public Randevu()
        {
            InitializeComponent();
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            baglanti.Open();
            string sorgu1 = "Select doktor_id as id,doktor_tc as tc,doktor_ad as ad,doktor_soyad as soyad,eposta,uzmanlik.bolum_adi,gorev_yapilan_hastane as hastane From doktor inner join uzmanlik on doktor.uzmanlik=uzmanlik.id where uzmanlik='" + txtAra.Text + "'";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
            baglanti.Close();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            
            Randevu_Al frmA = new Randevu_Al();
            frmA.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from randevulistele()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from randevu_al where randevu_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtRandevuSil.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oda silindi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
