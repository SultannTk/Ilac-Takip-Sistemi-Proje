using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlacTakipSistemiProje
{
    using MySql.Data.MySqlClient;

    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
                return;
            }

            Kullanici yeniKullanici = new Kullanici(kullaniciAdi, sifre);
            VeritabaniYonetici vt = new VeritabaniYonetici();

            if (vt.KullaniciEkle(yeniKullanici))
            {
                MessageBox.Show("Kayıt başarılı!");
                GirisFormu giris = new GirisFormu();
                giris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt sırasında hata oluştu.");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisFormu girisForm = new GirisFormu();
            girisForm.Show();
            this.Hide();
        }
    }
}
