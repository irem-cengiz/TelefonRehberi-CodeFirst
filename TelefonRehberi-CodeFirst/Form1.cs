using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;
using TelefonRehberi_CodeFirst.Classes;
using TelefonRehberi_CodeFirst.Context;

namespace TelefonRehberi_CodeFirst
{
    public partial class Form1 : Form
    {
        RehberContext db = new RehberContext();
        public Form1()
        {

            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            dgvRehber.DataSource = db.Kisiler.ToList();
        }

        private void btnRehbereEkle_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            string ad = txtAd.Text.Trim();
            k.Ad = ad;
            if (ad == "")
            {
                MessageBox.Show("Bir ad girmelisiniz");
                return;
            }
            string soyad = txtSoyad.Text.Trim();
            if (soyad == "")
            {
                MessageBox.Show("Bir soyad girmelisiniz");
                return;
            }
            k.Soyad = soyad;
            string telefonno = (txtTelefon.Text);
            k.TelefonNo = telefonno;

            db.Kisiler.Add(k);
            db.SaveChanges();
            Listele();

        }

        private void btnKisiAra_Click(object sender, EventArgs e)
        {
            dgvRehber.DataSource = null;
            dgvRehber.Rows.Clear();
            string aranan = txtAdSoyad.Text.Trim();

            var aramaSonuclari = db.Kisiler.Where(k => k.Ad.Contains(aranan) || k.Soyad.Contains(aranan)).ToList();
            dgvRehber.DataSource = aramaSonuclari;


            //var kisiler = db.Kisiler.ToList();
            //dgvRehber.Columns.Add("Ad", "Ad");
            //dgvRehber.Columns.Add("Soyad", "Soyad");

            //foreach (var kisi in kisiler)
            //{
            //    string ad = kisi.Ad;
            //    string soyad = kisi.Soyad;

            //    if (ad.Contains(aranan) || soyad.Contains(aranan))

            //    {
            //        dgvRehber.Rows.Add(ad,soyad);

            //    }

            //}

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = dgvRehber.SelectedRows[0];
            Kisi k = selectedRow.DataBoundItem as Kisi;
            if (k == null)
            {
                MessageBox.Show(" Silmek için kiþi seçiniz.");
                return;
            }

            db.Remove(k);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Seçilen kiþi kaldýrýlmýþtýr.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ad2 = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string telefonno = (txtTelefon.Text);
            DataGridViewRow selectedRow = dgvRehber.SelectedRows[0];
            Kisi k = selectedRow.DataBoundItem as Kisi;

            if (k == null)
            {
                MessageBox.Show(" Güncellemek için kiþi seçiniz.");
                return;
            }

            k.Ad = ad2;
            k.Soyad = soyad;
            k.TelefonNo = telefonno;
            db.Update(k);

            db.SaveChanges();
            Listele();
            MessageBox.Show("Kiþi güncellenmiþtir.");
        }


        private void dgvRehber_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvRehber.SelectedRows.Count == 0)
            {
                Temizle();
                return;
            }
            DataGridViewRow selectedRow = dgvRehber.SelectedRows[0];
            Kisi k = selectedRow.DataBoundItem as Kisi;

            if (k == null)
            {
                Temizle();
                return;
            }
            txtAd.Text = k.Ad;
            txtSoyad.Text = k.Soyad;
            txtTelefon.Text = k.TelefonNo;

        }
        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
        }
    }
}