﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane_Kitap_uml
{
    class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }

        public Kitap(string baslik, string yazar)
        {
            Baslik = baslik;
            Yazar = yazar;
        }

        public void KitapBilgisi()
        {
            Console.WriteLine($"Kitap Başlığı: {Baslik}, Yazar: {Yazar}");
        }
    }

    class Kutuphane
    {
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; } = new List<Kitap>();

        public Kutuphane(string ad)
        {
            Ad = ad;
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }
}