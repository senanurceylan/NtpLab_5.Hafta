using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazarKitap_uml
{
    class Kitap
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Yazar Yazar { get; set; }

        public Kitap(string baslik, DateTime yayinTarihi)
        {
            Baslik = baslik;
            YayinTarihi = yayinTarihi;
        }

        public void YazarAtama(Yazar yazar)
        {
            if (Yazar != yazar)
            {
                Yazar = yazar;
                yazar.KitapEkle(this);
            }
        }
    }

    class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
        }

        public void KitapEkle(Kitap kitap)
        {
            if (!Kitaplar.Contains(kitap))
            {
                Kitaplar.Add(kitap);
                kitap.YazarAtama(this);
            }
        }
    }
}