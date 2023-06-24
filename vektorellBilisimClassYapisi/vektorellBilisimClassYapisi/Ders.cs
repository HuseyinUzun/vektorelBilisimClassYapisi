using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace vektorellBilisimClassYapisi
{
    internal class Ders
    {
        public string Ad;
        public List<Grup> Gruplar;

        public Ders(string ad)
        {
            Ad = ad;
            Gruplar = new List<Grup>();
        }
    }
}
