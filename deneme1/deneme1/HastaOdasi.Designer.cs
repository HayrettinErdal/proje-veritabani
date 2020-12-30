
namespace deneme1
{
    partial class HastaOdasi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOdaGoruntule = new System.Windows.Forms.Button();
            this.txthastaAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtOdaSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(123, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane Odaları";
            // 
            // txtOdaGoruntule
            // 
            this.txtOdaGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOdaGoruntule.Location = new System.Drawing.Point(46, 619);
            this.txtOdaGoruntule.Name = "txtOdaGoruntule";
            this.txtOdaGoruntule.Size = new System.Drawing.Size(336, 97);
            this.txtOdaGoruntule.TabIndex = 2;
            this.txtOdaGoruntule.Text = "Hasta Odalarını Görüntüle";
            this.txtOdaGoruntule.UseVisualStyleBackColor = true;
            this.txtOdaGoruntule.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthastaAra
            // 
            this.txthastaAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txthastaAra.Location = new System.Drawing.Point(851, 619);
            this.txthastaAra.Name = "txthastaAra";
            this.txthastaAra.Size = new System.Drawing.Size(336, 97);
            this.txthastaAra.TabIndex = 3;
            this.txthastaAra.Text = "Hasta Ara";
            this.txthastaAra.UseVisualStyleBackColor = true;
            this.txthastaAra.Click += new System.EventHandler(this.txthastaAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(892, 552);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 30);
            this.txtAra.TabIndex = 5;
            // 
            // txtOdaSil
            // 
            this.txtOdaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOdaSil.Location = new System.Drawing.Point(434, 619);
            this.txtOdaSil.Name = "txtOdaSil";
            this.txtOdaSil.Size = new System.Drawing.Size(336, 97);
            this.txtOdaSil.TabIndex = 6;
            this.txtOdaSil.Text = "Oda Sil";
            this.txtOdaSil.UseVisualStyleBackColor = true;
            this.txtOdaSil.Click += new System.EventHandler(this.txtOdaSil_Click);
            // 
            // HastaOdasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 753);
            this.Controls.Add(this.txtOdaSil);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthastaAra);
            this.Controls.Add(this.txtOdaGoruntule);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HastaOdasi";
            this.Text = "HastaOdasi";
            this.Load += new System.EventHandler(this.HastaOdasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtOdaGoruntule;
        private System.Windows.Forms.Button txthastaAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button txtOdaSil;
    }
}