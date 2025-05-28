namespace IlacTakipSistemiProje
{
    public partial class Form1 : Form
    {
        private Kullanici aktifKullanici;
        private int seciliIlacId = -1;

        public Form1(Kullanici kullanici)
        {
            InitializeComponent();
            aktifKullanici = kullanici;
            this.Text = $"Ho� geldin, {aktifKullanici.KullaniciAdi}";

        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            string secilenIlacAdi = txtIlacAdi.Text.Trim();
            string secilenDozaj = txtDozaj.Text.Trim();

            VeritabaniYonetici vt = new VeritabaniYonetici();

            var secilenHazirIlac = vt.HazirIlaclariGetir()
                .FirstOrDefault(i => i.IlacAdi == secilenIlacAdi && i.Dozaj == secilenDozaj);

            if (secilenHazirIlac == null)
            {
                MessageBox.Show("Se�ilen ila� haz�r ila�lar aras�nda bulunamad�!");
                return;
            }

            var kullaniciIlaclari = vt.IlaclariGetir(aktifKullanici.Id);
            var riskliKombinasyonlar = vt.RiskliKombinasyonlariGetir();

            foreach (var risk in riskliKombinasyonlar)
            {
                bool yeniIlacRiskli1 = secilenHazirIlac.Id == risk.Ilac1Id;
                bool yeniIlacRiskli2 = secilenHazirIlac.Id == risk.Ilac2Id;

                bool digerIlacVar =
                    kullaniciIlaclari.Any(i => i.IlacAdi == vt.HazirIlaclariGetir().FirstOrDefault(h => h.Id == risk.Ilac2Id)?.IlacAdi) && yeniIlacRiskli1 ||
                    kullaniciIlaclari.Any(i => i.IlacAdi == vt.HazirIlaclariGetir().FirstOrDefault(h => h.Id == risk.Ilac1Id)?.IlacAdi) && yeniIlacRiskli2;

                if (digerIlacVar)
                {
                    MessageBox.Show("?? Bu ila� daha �nce eklenmi� ba�ka bir ila�la R�SKL� KOMB�NASYON olu�turuyor!\n\n?? A��klama:\n" + risk.Aciklama, "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }

            // Ekleme i�lemi
            Ilac yeniIlac = new Ilac
            {
                KullaniciId = aktifKullanici.Id,
                IlacAdi = secilenIlacAdi,
                Dozaj = secilenDozaj,
                BaslangicTarihi = dtpBaslangic.Value.Date,
                BitisTarihi = dtpBitis.Value.Date,
                HatirlatmaSaati = dtpSaat.Value.TimeOfDay
            };

            bool basarili = vt.IlacEkle(yeniIlac);

            if (basarili)
            {
                MessageBox.Show("�la� ba�ar�yla eklendi!");
                IlaclariListele(); // Listeyi g�ncelle!
            }
            else
                MessageBox.Show("�la� eklenemedi!");

            lstHazirIlaclar.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            IlaclariListele();
            timer1.Start();
            lstHazirIlaclar.Visible = false;
        }
        private void IlaclariListele()
        {
            VeritabaniYonetici vt = new VeritabaniYonetici();
            List<Ilac> ilaclar = vt.IlaclariGetir(aktifKullanici.Id);
            dgvIlaclar.DataSource = ilaclar;
        }

        private void dgvIlaclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgvIlaclar.Rows[e.RowIndex];

                seciliIlacId = Convert.ToInt32(satir.Cells["Id"].Value);
                txtIlacAdi.Text = satir.Cells["IlacAdi"].Value.ToString();
                txtDozaj.Text = satir.Cells["Dozaj"].Value.ToString();
                dtpBaslangic.Value = Convert.ToDateTime(satir.Cells["BaslangicTarihi"].Value);
                dtpBitis.Value = Convert.ToDateTime(satir.Cells["BitisTarihi"].Value);
                dtpSaat.Value = DateTime.Today.Add(TimeSpan.Parse(satir.Cells["HatirlatmaSaati"].Value.ToString()));
            }
        }

        private void btnIlacDuzenle_Click(object sender, EventArgs e)
        {
            if (seciliIlacId == -1)
            {
                MessageBox.Show("L�tfen d�zenlenecek ilac� se�in.");
                return;
            }

            Ilac guncellenenIlac = new Ilac
            {
                Id = seciliIlacId,
                KullaniciId = aktifKullanici.Id,
                IlacAdi = txtIlacAdi.Text.Trim(),
                Dozaj = txtDozaj.Text.Trim(),
                BaslangicTarihi = dtpBaslangic.Value.Date,
                BitisTarihi = dtpBitis.Value.Date,
                HatirlatmaSaati = dtpSaat.Value.TimeOfDay
            };

            VeritabaniYonetici vt = new VeritabaniYonetici();
            bool basarili = vt.IlacGuncelle(guncellenenIlac);

            if (basarili)
            {
                MessageBox.Show("�la� ba�ar�yla g�ncellendi!");
                IlaclariListele();
                seciliIlacId = -1;
            }
            else
            {
                MessageBox.Show("�la� g�ncellenemedi!");
            }
        }

        private void btnIlacSil_Click(object sender, EventArgs e)
        {
            if (seciliIlacId == -1)
            {
                MessageBox.Show("L�tfen silinecek ilac� se�in.");
                return;
            }

            DialogResult sonuc = MessageBox.Show("�lac� silmek istedi�inizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                VeritabaniYonetici vt = new VeritabaniYonetici();
                bool basarili = vt.IlacSil(seciliIlacId, aktifKullanici.Id);

                if (basarili)
                {
                    MessageBox.Show("�la� silindi.");
                    IlaclariListele();
                    seciliIlacId = -1;
                }
                else
                {
                    MessageBox.Show("�la� silinemedi.");
                }
            }
        }

        private void dgvIlaclar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIlaclar.CurrentRow != null)
            {
                seciliIlacId = Convert.ToInt32(dgvIlaclar.CurrentRow.Cells["Id"].Value);
            }
        }

        private void btnYanEtkileriGoster_Click(object sender, EventArgs e)
        {
            if (seciliIlacId == 0)
            {
                MessageBox.Show("L�tfen �nce bir ila� se�iniz.");
                return;
            }

            VeritabaniYonetici vt = new VeritabaniYonetici();
            List<YanEtki> yanEtkiler = vt.YanEtkileriGetir(seciliIlacId);

            string mesaj = yanEtkiler.Count == 0 ? "Bu ilaca ait yan etki bulunmamaktad�r." :
                "- " + string.Join("\n- ", yanEtkiler.Select(y => y.Aciklama));

            MessageBox.Show(mesaj, "Yan Etkiler");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VeritabaniYonetici vt = new VeritabaniYonetici();
            List<Ilac> ilaclar = vt.IlaclariGetir(aktifKullanici.Id);
            TimeSpan simdikiSaat = DateTime.Now.TimeOfDay;

            foreach (var ilac in ilaclar)
            {
                // Hat�rlatma saatini dakikaya yuvarla
                if (Math.Abs((simdikiSaat - ilac.HatirlatmaSaati).TotalMinutes) < 1)
                {
                    MessageBox.Show($"{ilac.IlacAdi} ilac�n� alma zaman�!", "�la� Hat�rlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnIlacSec_Click(object sender, EventArgs e)
        {
            lstHazirIlaclar.Visible = true;
            // Haz�r ila�lar� veritaban�ndan getirip listbox'a doldurabilirsin:
            HazirIlaclariYukle();
        }
        private void HazirIlaclariYukle()
        {
            VeritabaniYonetici vt = new VeritabaniYonetici();
            List<HazirIlac> ilaclar = vt.HazirIlaclariGetir(); // Bu metodu VeritabaniYonetici'de olu�turmal�s�n

            lstHazirIlaclar.DataSource = ilaclar;
            lstHazirIlaclar.DisplayMember = "IlacAdi";   // Listbox'ta sadece ila� ad� g�sterilir
            lstHazirIlaclar.ValueMember = "Id";          // Opsiyonel: id de�eri tutulur
        }

        private void lstHazirIlaclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHazirIlaclar.SelectedItem is HazirIlac seciliIlac)
            {
                txtIlacAdi.Text = seciliIlac.IlacAdi;
                txtDozaj.Text = seciliIlac.Dozaj;
            }
        }
    }
}


    
    

