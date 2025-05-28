using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemiProje
{
    public class RiskliIlacKombinasyonu
    {
        public int Id { get; set; }
        public int Ilac1Id { get; set; }
        public int Ilac2Id { get; set; }
        public string Aciklama { get; set; }
    }
}
