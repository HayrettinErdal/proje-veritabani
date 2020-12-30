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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoktor frmD = new frmDoktor();
            frmD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Randevu_Al frmA = new Randevu_Al();
            frmA.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hastaEkle frmH = new hastaEkle();
            frmH.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Randevu frmG = new Randevu();
            frmG.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HastaOdasi frmA = new HastaOdasi();
            frmA.Show();
        }
    }
}
