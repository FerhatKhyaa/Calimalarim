using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adonet_Sinif_Ogrenci_Listesi
{
    public partial class Form1 : Form
    {
        SinifDal _sinifDal = new SinifDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvOgrenciListesi.DataSource = _sinifDal.Goster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Sinif veriEkle = new Sinif {
            OgrenciAdi = tbxOgrenciAdi.Text.ToString(),
            OkulNumarasi = Convert.ToInt32(tbxOkulNo.Text),
            Bolum = tbxBolum.Text.ToString(),
            };
            _sinifDal.Ekle(veriEkle);

            dgvOgrenciListesi.DataSource = _sinifDal.Goster();

            MessageBox.Show("Eklendi!");
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Sinif duzenle = new Sinif
            {
                Id = Convert.ToInt32(dgvOgrenciListesi.CurrentRow.Cells[0].Value),
                OgrenciAdi = tbxOgrenciAdiDegis.Text.ToString(),
                OkulNumarasi = Convert.ToInt32(tbxOkulNoDegis.Text),
                Bolum = tbxBolumDegis.Text.ToString(),
            };
            _sinifDal.Duzenle(duzenle);
            dgvOgrenciListesi.DataSource = _sinifDal.Goster();
            MessageBox.Show("Düzenlendi!");
        }

        private void dgvOgrenciListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxOgrenciAdiDegis.Text = dgvOgrenciListesi.CurrentRow.Cells[1].Value.ToString();
            tbxOkulNoDegis.Text = dgvOgrenciListesi.CurrentRow.Cells[2].Value.ToString();
            tbxBolumDegis.Text = dgvOgrenciListesi.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnVeriyiSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvOgrenciListesi.CurrentRow.Cells[0].Value);

            _sinifDal.Sil(id);

            dgvOgrenciListesi.DataSource = _sinifDal.Goster();

            MessageBox.Show("Silindi!");
        }
    }
}
