using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirket_Calisan_uml
{
    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Sirket Sirket { get; set; }

        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }

        public void SirketAtama(Sirket sirket)
        {
            if (Sirket != sirket)
            {
                Sirket = sirket;
                sirket.CalisanEkle(this);
            }
        }
    }

    class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        public Sirket(string ad, string konum)
        {
            Ad = ad;
            Konum = konum;
        }

        public void CalisanEkle(Calisan calisan)
        {
            if (!Calisanlar.Contains(calisan))
            {
                Calisanlar.Add(calisan);
                calisan.SirketAtama(this);
            }
        }
    }
