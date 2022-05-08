namespace Adonet_Sinif_Ogrenci_Listesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVeriyiSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.tbxBolumDegis = new System.Windows.Forms.TextBox();
            this.tbxOkulNoDegis = new System.Windows.Forms.TextBox();
            this.tbxOgrenciAdiDegis = new System.Windows.Forms.TextBox();
            this.lblBolumDegis = new System.Windows.Forms.Label();
            this.lblOkulNoDegis = new System.Windows.Forms.Label();
            this.lblOgrenciAdiDegis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbxBolum = new System.Windows.Forms.TextBox();
            this.tbxOkulNo = new System.Windows.Forms.TextBox();
            this.tbxOgrenciAdi = new System.Windows.Forms.TextBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.lblOgrenciAdi = new System.Windows.Forms.Label();
            this.dgvOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVeriyiSil
            // 
            this.btnVeriyiSil.Location = new System.Drawing.Point(352, 227);
            this.btnVeriyiSil.Name = "btnVeriyiSil";
            this.btnVeriyiSil.Size = new System.Drawing.Size(96, 23);
            this.btnVeriyiSil.TabIndex = 13;
            this.btnVeriyiSil.Text = "Verileri Temizle";
            this.btnVeriyiSil.UseVisualStyleBackColor = true;
            this.btnVeriyiSil.Click += new System.EventHandler(this.btnVeriyiSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.tbxBolumDegis);
            this.groupBox2.Controls.Add(this.tbxOkulNoDegis);
            this.groupBox2.Controls.Add(this.tbxOgrenciAdiDegis);
            this.groupBox2.Controls.Add(this.lblBolumDegis);
            this.groupBox2.Controls.Add(this.lblOkulNoDegis);
            this.groupBox2.Controls.Add(this.lblOgrenciAdiDegis);
            this.groupBox2.Location = new System.Drawing.Point(539, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 216);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgileri Düzenle";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(145, 152);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // tbxBolumDegis
            // 
            this.tbxBolumDegis.Location = new System.Drawing.Point(87, 102);
            this.tbxBolumDegis.Name = "tbxBolumDegis";
            this.tbxBolumDegis.Size = new System.Drawing.Size(153, 20);
            this.tbxBolumDegis.TabIndex = 11;
            // 
            // tbxOkulNoDegis
            // 
            this.tbxOkulNoDegis.Location = new System.Drawing.Point(87, 65);
            this.tbxOkulNoDegis.Name = "tbxOkulNoDegis";
            this.tbxOkulNoDegis.Size = new System.Drawing.Size(153, 20);
            this.tbxOkulNoDegis.TabIndex = 10;
            // 
            // tbxOgrenciAdiDegis
            // 
            this.tbxOgrenciAdiDegis.Location = new System.Drawing.Point(86, 29);
            this.tbxOgrenciAdiDegis.Name = "tbxOgrenciAdiDegis";
            this.tbxOgrenciAdiDegis.Size = new System.Drawing.Size(153, 20);
            this.tbxOgrenciAdiDegis.TabIndex = 9;
            // 
            // lblBolumDegis
            // 
            this.lblBolumDegis.AutoSize = true;
            this.lblBolumDegis.Location = new System.Drawing.Point(6, 105);
            this.lblBolumDegis.Name = "lblBolumDegis";
            this.lblBolumDegis.Size = new System.Drawing.Size(39, 13);
            this.lblBolumDegis.TabIndex = 8;
            this.lblBolumDegis.Text = "Bölüm:";
            // 
            // lblOkulNoDegis
            // 
            this.lblOkulNoDegis.AutoSize = true;
            this.lblOkulNoDegis.Location = new System.Drawing.Point(6, 68);
            this.lblOkulNoDegis.Name = "lblOkulNoDegis";
            this.lblOkulNoDegis.Size = new System.Drawing.Size(79, 13);
            this.lblOkulNoDegis.TabIndex = 7;
            this.lblOkulNoDegis.Text = "Okul Numarası:";
            // 
            // lblOgrenciAdiDegis
            // 
            this.lblOgrenciAdiDegis.AutoSize = true;
            this.lblOgrenciAdiDegis.Location = new System.Drawing.Point(6, 32);
            this.lblOgrenciAdiDegis.Name = "lblOgrenciAdiDegis";
            this.lblOgrenciAdiDegis.Size = new System.Drawing.Size(65, 13);
            this.lblOgrenciAdiDegis.TabIndex = 6;
            this.lblOgrenciAdiDegis.Text = "Öğrenci Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.tbxBolum);
            this.groupBox1.Controls.Add(this.tbxOkulNo);
            this.groupBox1.Controls.Add(this.tbxOgrenciAdi);
            this.groupBox1.Controls.Add(this.lblBolum);
            this.groupBox1.Controls.Add(this.lblOkulNo);
            this.groupBox1.Controls.Add(this.lblOgrenciAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 216);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgileri Kaydet";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(146, 152);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbxBolum
            // 
            this.tbxBolum.Location = new System.Drawing.Point(87, 102);
            this.tbxBolum.Name = "tbxBolum";
            this.tbxBolum.Size = new System.Drawing.Size(152, 20);
            this.tbxBolum.TabIndex = 8;
            // 
            // tbxOkulNo
            // 
            this.tbxOkulNo.Location = new System.Drawing.Point(87, 65);
            this.tbxOkulNo.Name = "tbxOkulNo";
            this.tbxOkulNo.Size = new System.Drawing.Size(152, 20);
            this.tbxOkulNo.TabIndex = 7;
            // 
            // tbxOgrenciAdi
            // 
            this.tbxOgrenciAdi.Location = new System.Drawing.Point(86, 29);
            this.tbxOgrenciAdi.Name = "tbxOgrenciAdi";
            this.tbxOgrenciAdi.Size = new System.Drawing.Size(152, 20);
            this.tbxOgrenciAdi.TabIndex = 6;
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(6, 105);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(39, 13);
            this.lblBolum.TabIndex = 5;
            this.lblBolum.Text = "Bölüm:";
            // 
            // lblOkulNo
            // 
            this.lblOkulNo.AutoSize = true;
            this.lblOkulNo.Location = new System.Drawing.Point(6, 68);
            this.lblOkulNo.Name = "lblOkulNo";
            this.lblOkulNo.Size = new System.Drawing.Size(79, 13);
            this.lblOkulNo.TabIndex = 4;
            this.lblOkulNo.Text = "Okul Numarası:";
            // 
            // lblOgrenciAdi
            // 
            this.lblOgrenciAdi.AutoSize = true;
            this.lblOgrenciAdi.Location = new System.Drawing.Point(6, 32);
            this.lblOgrenciAdi.Name = "lblOgrenciAdi";
            this.lblOgrenciAdi.Size = new System.Drawing.Size(65, 13);
            this.lblOgrenciAdi.TabIndex = 3;
            this.lblOgrenciAdi.Text = "Öğrenci Adı:";
            // 
            // dgvOgrenciListesi
            // 
            this.dgvOgrenciListesi.AllowUserToDeleteRows = false;
            this.dgvOgrenciListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciListesi.Location = new System.Drawing.Point(12, 8);
            this.dgvOgrenciListesi.Name = "dgvOgrenciListesi";
            this.dgvOgrenciListesi.ReadOnly = true;
            this.dgvOgrenciListesi.Size = new System.Drawing.Size(776, 213);
            this.dgvOgrenciListesi.TabIndex = 10;
            this.dgvOgrenciListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciListesi_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVeriyiSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOgrenciListesi);
            this.Name = "Form1";
            this.Text = "AdoNet Sınıftaki Öğrenci Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeriyiSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox tbxBolumDegis;
        private System.Windows.Forms.TextBox tbxOkulNoDegis;
        private System.Windows.Forms.TextBox tbxOgrenciAdiDegis;
        private System.Windows.Forms.Label lblBolumDegis;
        private System.Windows.Forms.Label lblOkulNoDegis;
        private System.Windows.Forms.Label lblOgrenciAdiDegis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbxBolum;
        private System.Windows.Forms.TextBox tbxOkulNo;
        private System.Windows.Forms.TextBox tbxOgrenciAdi;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.Label lblOgrenciAdi;
        private System.Windows.Forms.DataGridView dgvOgrenciListesi;
    }
}

