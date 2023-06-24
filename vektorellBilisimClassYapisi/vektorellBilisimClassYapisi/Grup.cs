using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektorellBilisimClassYapisi
{
    internal class Grup
    {
        public string Ad;
        public List<Ogrenci> Ogrenciler;

        public Grup(string ad)
        {
            Ad = ad;
            Ogrenciler = new List<Ogrenci>();
        }
    }
}
