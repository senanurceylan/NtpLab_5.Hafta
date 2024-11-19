using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şirket_Çalisan_uml
{
    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }

        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }

        public void CalisanBilgisi()
        {
            Console.WriteLine($"Çalışan Adı: {Ad}, Pozisyon: {Pozisyon}");
        }
    }

    class Sirket
    {
        public string Ad { get; set; }
        public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

        public Sirket(string ad)
        {
            Ad = ad;
        }

        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
        }
    }
}
