using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Ogrenci_uml
{
    class Program
    {
        class Ogrenci
        {
            public string Ad { get; set; }
            public int Yas { get; set; }

            public Ogrenci(string ad, int yas)
            {
                Ad = ad;
                Yas = yas;
            }

            public void OgrenciBilgisi()
            {
                Console.WriteLine($"Öğrenci Adı: {Ad}, Yaş: {Yas}");
            }
        }

        class Okul
        {
            public string Ad { get; set; }
            public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();

            public Okul(string ad)
            {
                Ad = ad;
            }

            public void OgrenciEkle(Ogrenci ogrenci)
            {
                Ogrenciler.Add(ogrenci);
            }
        }
    }
}