using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemiProje
{
    public class Ilac
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string IlacAdi { get; set; }
        public string Dozaj { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public TimeSpan HatirlatmaSaati { get; set; }

        public Ilac() { }

        public Ilac(int kullaniciId, string ilacAdi, string dozaj, DateTime baslangic, DateTime bitis, TimeSpan saat)
        {
            KullaniciId = kullaniciId;
            IlacAdi = ilacAdi;
            Dozaj = dozaj;
            BaslangicTarihi = baslangic;
            BitisTarihi = bitis;
            HatirlatmaSaati = saat;
        }
    }
}
