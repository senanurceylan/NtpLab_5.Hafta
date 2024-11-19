using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteri_Siparis_uml
{
    class Musteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }

        public Musteri(string ad, string telefon)
        {
            Ad = ad;
            Telefon = telefon;
        }

        public void SiparisVer(Siparis siparis)
        {
            Console.WriteLine($"{Ad} adlı müşteri yeni bir sipariş verdi.");
        }
    }

    class Siparis
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }

        public Siparis(DateTime tarih, string durum)
        {
            Tarih = tarih;
            Durum = durum;
        }
    }
}
