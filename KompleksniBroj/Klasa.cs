using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksniBroj
{
    class KompleksniBrojKlasa
    {


        public KompleksniBrojKlasa(double relalni, double imaginarni)
        {
            RealniDio = relalni;
            ImaginarniDio = imaginarni;
        }

        public double RealniDio;
        public double ImaginarniDio;


        public override string ToString()
        {
            return $"({RealniDio}, {ImaginarniDio})";
        }
    }
}
