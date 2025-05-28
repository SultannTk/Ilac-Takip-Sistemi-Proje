using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IlacTakipSistemiProje
{
    public class VeritabaniYonetici
    {
        private string baglantiCumlesi = "server=localhost;user=root;database=ilactakipvt;port=3306;password=12345678";

        public bool KullaniciEkle(Kullanici kullanici)
        {
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = "INSERT INTO kullanici (kullaniciadi, sifre) VALUES (@kullaniciadi, @sifre)";
                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullanici.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt hatası: " + ex.Message);
                return false;
            }
        }

        public bool GirisYap(string kullaniciAdi, string sifre, out Kullanici aktifKullanici)
        {
            aktifKullanici = null;
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = "SELECT * FROM kullanici WHERE kullaniciadi = @kullaniciadi AND sifre = @sifre";
                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            aktifKullanici = new Kullanici
                            {
                                Id = reader.GetInt32("id"),
                                KullaniciAdi = reader.GetString("kullaniciadi"),
                                Sifre = reader.GetString("sifre")
                            };
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş hatası: " + ex.Message);
            }

            return false;
        }
        public bool IlacEkle(Ilac ilac)
        {
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = @"INSERT INTO ilac 
    (kullaniciId, ilacAdi, dozaj, baslangicTarihi, bitisTarihi, hatirlatmaSaati) 
    VALUES 
    (@kullaniciId, @ilacAdi, @dozaj, @baslangicTarihi, @bitisTarihi, @hatirlatmaSaati)";

                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@kullaniciId", ilac.KullaniciId);
                    cmd.Parameters.AddWithValue("@ilacAdi", ilac.IlacAdi);
                    cmd.Parameters.AddWithValue("@dozaj", ilac.Dozaj);
                    cmd.Parameters.AddWithValue("@baslangicTarihi", ilac.BaslangicTarihi);
                    cmd.Parameters.AddWithValue("@bitisTarihi", ilac.BitisTarihi);
                    cmd.Parameters.AddWithValue("@hatirlatmaSaati", ilac.HatirlatmaSaati);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İlaç eklenirken hata oluştu: " + ex.Message);
                return false;
            }
        }
        public List<Ilac> IlaclariGetir(int kullaniciId)
        {
            List<Ilac> ilaclar = new List<Ilac>();

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = "SELECT * FROM ilac WHERE kullaniciId = @kullaniciId";
                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Ilac ilac = new Ilac
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                KullaniciId = Convert.ToInt32(dr["kullaniciId"]),
                                IlacAdi = dr["ilacAdi"].ToString(),
                                Dozaj = dr["dozaj"].ToString(),
                                BaslangicTarihi = Convert.ToDateTime(dr["baslangicTarihi"]),
                                BitisTarihi = Convert.ToDateTime(dr["bitisTarihi"]),
                                HatirlatmaSaati = TimeSpan.Parse(dr["hatirlatmaSaati"].ToString())
                            };

                            ilaclar.Add(ilac);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İlaçlar getirilirken hata oluştu: " + ex.Message);
            }

            return ilaclar;
        }
        public bool IlacGuncelle(Ilac ilac)
        {
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = @"UPDATE ilac 
                             SET ilacAdi = @ilacAdi, dozaj = @dozaj, 
                                 baslangicTarihi = @baslangicTarihi, 
                                 bitisTarihi = @bitisTarihi, 
                                 hatirlatmaSaati = @hatirlatmaSaati 
                             WHERE id = @id AND kullaniciId = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@id", ilac.Id);
                    cmd.Parameters.AddWithValue("@kullaniciId", ilac.KullaniciId);
                    cmd.Parameters.AddWithValue("@ilacAdi", ilac.IlacAdi);
                    cmd.Parameters.AddWithValue("@dozaj", ilac.Dozaj);
                    cmd.Parameters.AddWithValue("@baslangicTarihi", ilac.BaslangicTarihi);
                    cmd.Parameters.AddWithValue("@bitisTarihi", ilac.BitisTarihi);
                    cmd.Parameters.AddWithValue("@hatirlatmaSaati", ilac.HatirlatmaSaati);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İlaç güncellenirken hata oluştu: " + ex.Message);
                return false;
            }
        }
        public bool IlacSil(int id, int kullaniciId)
        {
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = "DELETE FROM ilac WHERE id = @id AND kullaniciId = @kullaniciId";
                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("İlaç silinirken hata oluştu: " + ex.Message);
                return false;
            }
        }
        public List<YanEtki> YanEtkileriGetir(int ilacId)
        {
            List<YanEtki> yanEtkiler = new List<YanEtki>();

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = "SELECT * FROM yanetki WHERE ilacId = @ilacId";
                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@ilacId", ilacId);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            YanEtki yanEtki = new YanEtki
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                IlacId = Convert.ToInt32(dr["ilacId"]),
                                Aciklama = dr["aciklama"].ToString()
                            };
                            yanEtkiler.Add(yanEtki);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yan etkiler getirilirken hata oluştu: " + ex.Message);
            }

            return yanEtkiler;
        }
        public List<HazirIlac> HazirIlaclariGetir()
        {
            List<HazirIlac> ilaclar = new List<HazirIlac>();

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string komut = "SELECT id, ilac_adi, dozaj FROM hazir_ilaclar";  // hazirilaclar tablosu varsayımı
                    MySqlCommand cmd = new MySqlCommand(komut, baglanti);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ilaclar.Add(new HazirIlac
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                IlacAdi = dr["ilac_adi"].ToString(),
                                Dozaj = dr["dozaj"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hazır ilaçlar yüklenirken hata oluştu: " + ex.Message);
            }

            return ilaclar;
        }
        public List<RiskliIlacKombinasyonu> RiskliKombinasyonlariGetir()
        {
            List<RiskliIlacKombinasyonu> kombinasyonlar = new List<RiskliIlacKombinasyonu>();

            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    string sorgu = "SELECT * FROM riskli_ilac_kombinasyonlari";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            kombinasyonlar.Add(new RiskliIlacKombinasyonu
                            {
                                Id = Convert.ToInt32(dr["id"]),
                                Ilac1Id = Convert.ToInt32(dr["ilac1_id"]),
                                Ilac2Id = Convert.ToInt32(dr["ilac2_id"]),
                                Aciklama = dr["aciklama"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Riskli ilaç kombinasyonları getirilirken hata oluştu: " + ex.Message);
            }

            return kombinasyonlar;
        }

    }
}
