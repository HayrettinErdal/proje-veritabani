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
    public partial class HastaOdasi : Form
    {
        public HastaOdasi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Proje_Hastane; user ID=postgres; password=12345");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from hastaodalistesi()";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txthastaAra_Click(object sender, EventArgs e)
        {
            string sorgu1 = "Select * From hasta_odasi where hasta_id='" + txtAra.Text + "'";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void HastaOdasi_Load(object sender, EventArgs e)
        {

        }

        private void txtOdaSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from hasta_odasi where oda_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtAra.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oda silindi...", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }
    }
}
