
namespace deneme1
{
    partial class frmDoktor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHastane = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtNobetNo = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtMuayeneID = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.txtID2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 369);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kayıtlı Doktorlar";
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Location = new System.Drawing.Point(32, 492);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(185, 71);
            this.btnGoruntule.TabIndex = 2;
            this.btnGoruntule.Text = "Doktorları Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(874, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(868, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Eposta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(807, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Uzmanlık:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(920, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(214, 30);
            this.txtID.TabIndex = 9;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(920, 131);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(214, 30);
            this.txtTC.TabIndex = 10;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(920, 176);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(214, 30);
            this.txtAd.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.AcceptsReturn = true;
            this.txtSoyad.Location = new System.Drawing.Point(920, 219);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(214, 30);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(920, 266);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(214, 30);
            this.txtEposta.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(920, 646);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(214, 69);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Doktor Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(500, 613);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(154, 62);
            this.btnAra.TabIndex = 16;
            this.btnAra.Text = "Doktor Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Uzmanlık:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(815, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hastane:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(842, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Maaş:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(805, 478);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nobet No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(783, 531);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Personel ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(779, 587);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Muayene ID:";
            // 
            // txtHastane
            // 
            this.txtHastane.Location = new System.Drawing.Point(920, 365);
            this.txtHastane.Name = "txtHastane";
            this.txtHastane.Size = new System.Drawing.Size(214, 30);
            this.txtHastane.TabIndex = 24;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(920, 426);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(214, 30);
            this.txtMaas.TabIndex = 25;
            // 
            // txtNobetNo
            // 
            this.txtNobetNo.Location = new System.Drawing.Point(920, 478);
            this.txtNobetNo.Name = "txtNobetNo";
            this.txtNobetNo.Size = new System.Drawing.Size(214, 30);
            this.txtNobetNo.TabIndex = 26;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(920, 533);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(214, 30);
            this.txtPersonelID.TabIndex = 27;
            // 
            // txtMuayeneID
            // 
            this.txtMuayeneID.Location = new System.Drawing.Point(920, 587);
            this.txtMuayeneID.Name = "txtMuayeneID";
            this.txtMuayeneID.Size = new System.Drawing.Size(214, 30);
            this.txtMuayeneID.TabIndex = 28;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(460, 526);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(214, 30);
            this.txtAra.TabIndex = 29;
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(920, 309);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(214, 30);
            this.txtUzmanlik.TabIndex = 30;
            // 
            // txtID2
            // 
            this.txtID2.Location = new System.Drawing.Point(96, 629);
            this.txtID2.Name = "txtID2";
            this.txtID2.Size = new System.Drawing.Size(214, 30);
            this.txtID2.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 634);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "ID:";
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Location = new System.Drawing.Point(156, 675);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(154, 62);
            this.btnDoktorSil.TabIndex = 31;
            this.btnDoktorSil.Text = "Doktor Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // frmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 749);
            this.Controls.Add(this.txtID2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnDoktorSil);
            this.Controls.Add(this.txtUzmanlik);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtMuayeneID);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtNobetNo);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtHastane);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmDoktor";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHastane;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtNobetNo;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtMuayeneID;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.TextBox txtID2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDoktorSil;
    }
}