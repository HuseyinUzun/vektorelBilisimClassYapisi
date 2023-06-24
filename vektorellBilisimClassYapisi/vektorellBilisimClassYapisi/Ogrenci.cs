using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vektorellBilisimClassYapisi
{
    internal class Ogrenci
    {
        public int IDogrenci;
        public string Ad;
        public string Soyad;
        public double NotOrtalamasi;

       

        public Ogrenci(int IDogrenci, string ad, string soyad, double notOrtalamasi)
        {
            IDogrenci = IDogrenci;
            Ad = ad;
            soyad = soyad;
            NotOrtalamasi = notOrtalamasi;
        }
    }
}
