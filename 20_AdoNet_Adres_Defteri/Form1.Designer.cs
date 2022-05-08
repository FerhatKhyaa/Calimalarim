namespace _20_AdoNet_Adres_Defteri
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
            this.dgvAdresDefteri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.tbxAdSoyad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.tbxTelefonDegis = new System.Windows.Forms.TextBox();
            this.tbxAdresDegis = new System.Windows.Forms.TextBox();
            this.tbxAdSoyadDegis = new System.Windows.Forms.TextBox();
            this.lblTelefonDegis = new System.Windows.Forms.Label();
            this.lblAdresDegis = new System.Windows.Forms.Label();
            this.lblAdSoyadDegis = new System.Windows.Forms.Label();
            this.btnVeriyiSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresDefteri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdresDefteri
            // 
            this.dgvAdresDefteri.AllowUserToDeleteRows = false;
            this.dgvAdresDefteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdresDefteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdresDefteri.Location = new System.Drawing.Point(12, 12);
            this.dgvAdresDefteri.Name = "dgvAdresDefteri";
            this.dgvAdresDefteri.ReadOnly = true;
            this.dgvAdresDefteri.Size = new System.Drawing.Size(776, 213);
            this.dgvAdresDefteri.TabIndex = 0;
            this.dgvAdresDefteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdresDefteri_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.tbxTelefon);
            this.groupBox1.Controls.Add(this.tbxAdres);
            this.groupBox1.Controls.Add(this.tbxAdSoyad);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Location = new System.Drawing.Point(12, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 216);
            this.groupBox1.TabIndex = 1;
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
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(69, 102);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(152, 20);
            this.tbxTelefon.TabIndex = 8;
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(69, 65);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(152, 20);
            this.tbxAdres.TabIndex = 7;
            // 
            // tbxAdSoyad
            // 
            this.tbxAdSoyad.Location = new System.Drawing.Point(68, 29);
            this.tbxAdSoyad.Name = "tbxAdSoyad";
            this.tbxAdSoyad.Size = new System.Drawing.Size(152, 20);
            this.tbxAdSoyad.TabIndex = 6;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 105);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(63, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon No:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(6, 68);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(6, 32);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 13);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Ad-Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuzenle);
            this.groupBox2.Controls.Add(this.tbxTelefonDegis);
            this.groupBox2.Controls.Add(this.tbxAdresDegis);
            this.groupBox2.Controls.Add(this.tbxAdSoyadDegis);
            this.groupBox2.Controls.Add(this.lblTelefonDegis);
            this.groupBox2.Controls.Add(this.lblAdresDegis);
            this.groupBox2.Controls.Add(this.lblAdSoyadDegis);
            this.groupBox2.Location = new System.Drawing.Point(539, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 216);
            this.groupBox2.TabIndex = 2;
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
            // tbxTelefonDegis
            // 
            this.tbxTelefonDegis.Location = new System.Drawing.Point(69, 102);
            this.tbxTelefonDegis.Name = "tbxTelefonDegis";
            this.tbxTelefonDegis.Size = new System.Drawing.Size(152, 20);
            this.tbxTelefonDegis.TabIndex = 11;
            // 
            // tbxAdresDegis
            // 
            this.tbxAdresDegis.Location = new System.Drawing.Point(69, 65);
            this.tbxAdresDegis.Name = "tbxAdresDegis";
            this.tbxAdresDegis.Size = new System.Drawing.Size(152, 20);
            this.tbxAdresDegis.TabIndex = 10;
            // 
            // tbxAdSoyadDegis
            // 
            this.tbxAdSoyadDegis.Location = new System.Drawing.Point(68, 29);
            this.tbxAdSoyadDegis.Name = "tbxAdSoyadDegis";
            this.tbxAdSoyadDegis.Size = new System.Drawing.Size(152, 20);
            this.tbxAdSoyadDegis.TabIndex = 9;
            // 
            // lblTelefonDegis
            // 
            this.lblTelefonDegis.AutoSize = true;
            this.lblTelefonDegis.Location = new System.Drawing.Point(6, 105);
            this.lblTelefonDegis.Name = "lblTelefonDegis";
            this.lblTelefonDegis.Size = new System.Drawing.Size(63, 13);
            this.lblTelefonDegis.TabIndex = 8;
            this.lblTelefonDegis.Text = "Telefon No:";
            // 
            // lblAdresDegis
            // 
            this.lblAdresDegis.AutoSize = true;
            this.lblAdresDegis.Location = new System.Drawing.Point(6, 68);
            this.lblAdresDegis.Name = "lblAdresDegis";
            this.lblAdresDegis.Size = new System.Drawing.Size(37, 13);
            this.lblAdresDegis.TabIndex = 7;
            this.lblAdresDegis.Text = "Adres:";
            // 
            // lblAdSoyadDegis
            // 
            this.lblAdSoyadDegis.AutoSize = true;
            this.lblAdSoyadDegis.Location = new System.Drawing.Point(6, 32);
            this.lblAdSoyadDegis.Name = "lblAdSoyadDegis";
            this.lblAdSoyadDegis.Size = new System.Drawing.Size(56, 13);
            this.lblAdSoyadDegis.TabIndex = 6;
            this.lblAdSoyadDegis.Text = "Ad-Soyad:";
            // 
            // btnVeriyiSil
            // 
            this.btnVeriyiSil.Location = new System.Drawing.Point(352, 231);
            this.btnVeriyiSil.Name = "btnVeriyiSil";
            this.btnVeriyiSil.Size = new System.Drawing.Size(96, 23);
            this.btnVeriyiSil.TabIndex = 9;
            this.btnVeriyiSil.Text = "Verileri Temizle";
            this.btnVeriyiSil.UseVisualStyleBackColor = true;
            this.btnVeriyiSil.Click += new System.EventHandler(this.btnVeriyiSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVeriyiSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAdresDefteri);
            this.Name = "Form1";
            this.Text = "Adonet Adres Defteri Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdresDefteri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdresDefteri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTelefonDegis;
        private System.Windows.Forms.Label lblAdresDegis;
        private System.Windows.Forms.Label lblAdSoyadDegis;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxAdres;
        private System.Windows.Forms.TextBox tbxAdSoyad;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox tbxTelefonDegis;
        private System.Windows.Forms.TextBox tbxAdresDegis;
        private System.Windows.Forms.TextBox tbxAdSoyadDegis;
        private System.Windows.Forms.Button btnVeriyiSil;
    }
}

