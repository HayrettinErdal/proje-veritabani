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
    public partial class Randevu_Al : Form
    {
        public Randevu_Al()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Proje_Hastane; user ID=postgres; password=12345");

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Randevu_Al_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("select bolum_adi from uzmanlik", baglanti);
            NpgsqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                cmbBolum.Items.Add(dr[0].ToString());
            }
            baglanti.Close();

            // iller combobaxına illeri çekmek için
            baglanti.Open();
            NpgsqlCommand command = new NpgsqlCommand("select il_ad from il order by il_no", baglanti);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbilNo.Items.Add(dataReader[0]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into randevu_al (randevu_id,il_no,ilce_no,hastane_ismi,tarih,saat,muayene_yeri,hasta_id,bolum_no) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtRandevuID.Text));
            komut2.Parameters.AddWithValue("@p2", cmbilNo.Text);
            komut2.Parameters.AddWithValue("@p3", cmbilceNo.Text);
            komut2.Parameters.AddWithValue("@p4", txtHastaneIsmi.Text);
            komut2.Parameters.AddWithValue("@p5", txtTarih.Text);
            komut2.Parameters.AddWithValue("@p6", txtSaat.Text);
            komut2.Parameters.AddWithValue("@p7", txtMuayeneYeri.Text);
            komut2.Parameters.AddWithValue("@p8", int.Parse(txtHastaID.Text));
            komut2.Parameters.AddWithValue("@p9", int.Parse(txtBolumNo.Text));
            
            
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Randevu alma işlemi başarılı bir şekilde gerçekkeşti...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbilNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilceNo.Items.Clear();
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Select ilce_ad from ilce where il_no=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbilNo.SelectedIndex + 1); 
            NpgsqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmbilceNo.Items.Add(dataReader[0].ToString());
            }
            baglanti.Close();
        }
    }
}
