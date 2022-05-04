using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_AdoNet_Adres_Defteri
{
    public partial class Form1 : Form
    {
        AdresDal _adresDal = new AdresDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAdresDefteri.DataSource = _adresDal.Getir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Adres veriEkle = new Adres { 
            KisiAdi = tbxAdSoyad.Text.ToString(),
            Adress = tbxAdres.Text.ToString(),
            Telefon = tbxTelefon.Text.ToString()
            };
            _adresDal.Ekle(veriEkle);

            dgvAdresDefteri.DataSource = _adresDal.Getir();

            MessageBox.Show("Kayıt Ekleme İşleminiz Başarılı Bir Şekilde Gerçekleştirildi.");
        }

        private void dgvAdresDefteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAdSoyadDegis.Text = dgvAdresDefteri.CurrentRow.Cells[1].Value.ToString();
            tbxAdresDegis.Text = dgvAdresDefteri.CurrentRow.Cells[2].Value.ToString();
            tbxTelefonDegis.Text = dgvAdresDefteri.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnVeriyiSil_Click(object sender, EventArgs e)
        {
            int urunId = Convert.ToInt32(dgvAdresDefteri.CurrentRow.Cells[0].Value);

            _adresDal.Sil(urunId);

            dgvAdresDefteri.DataSource = _adresDal.Getir();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Adres duzenle = new Adres {
                Id = Convert.ToInt32(dgvAdresDefteri.CurrentRow.Cells[0].Value),
                KisiAdi = tbxAdSoyadDegis.Text.ToString(),
                Adress = tbxAdresDegis.Text.ToString(),
                Telefon = tbxTelefonDegis.Text.ToString()
            };
            _adresDal.Duzenle(duzenle);

            dgvAdresDefteri.DataSource = _adresDal.Getir();

            MessageBox.Show("Düzenleme İşlemi Yapıldı.");
        }
    }
}
