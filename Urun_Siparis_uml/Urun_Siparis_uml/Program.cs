using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urun_Siparis_uml
{
    class Urun
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        public Urun(string ad, int fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public void UrunBilgisi()
        {
            Console.WriteLine($"Ürün Adı: {Ad}, Fiyat: {Fiyat} TL");
        }
    }

    class Siparis
    {
        public DateTime Tarih { get; set; }
        public decimal Toplam { get; set; }
        public List<Urun> Urunler { get; set; } = new List<Urun>();

        public Siparis(DateTime tarih)
        {
            Tarih = tarih;
        }

        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
            Toplam += urun.Fiyat;
        }
    }