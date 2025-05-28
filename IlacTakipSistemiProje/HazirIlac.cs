using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlacTakipSistemiProje
{
    public class HazirIlac
    {
        public int Id { get; set; }
        public string IlacAdi { get; set; }
        public string Dozaj { get; set; }

        public override string ToString()
        {
            return $"{IlacAdi} - {Dozaj}";
        }
    }
}
