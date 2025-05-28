using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemiProje
{
    public class YanEtki
    {
        public int Id { get; set; }
        public int IlacId { get; set; }
        public string Aciklama { get; set; }

        public YanEtki() { }

        public YanEtki(int ilacId, string aciklama)
        {
            IlacId = ilacId;
            Aciklama = aciklama;
        }
    }
}
