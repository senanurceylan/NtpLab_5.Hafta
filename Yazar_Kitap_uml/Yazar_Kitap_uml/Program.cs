using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazar_Kitap_uml
{
    class Program
    {
        public string Baslik { get; set; }
        public string ISBN { get; set; }

        public Program(string baslik, string isbn)
        {
            Baslik = baslik;
            ISBN = isbn;
        }
    }

    class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Program> Kitaplar { get; set; } = new List<Program>();

        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
        }

        public void KitapEkle(Program kitap)
        {
            Kitaplar.Add(kitap);
        }
    }
}