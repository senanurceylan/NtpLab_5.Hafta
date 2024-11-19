using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Islemci_uml
{
    class Islemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; }

        public Islemci(int cekirdekler, int frekans)
        {
            Cekirdekler = cekirdekler;
            Frekans = frekans;
        }

        public void IslemciBilgisi()
        {
            Console.WriteLine($"Çekirdekler: {Cekirdekler}, Frekans: {Frekans} MHz");
        }
    }

    class Bilgisayar
    {
        public string Model { get; set; }
        public Islemci Islemci { get; set; }

        public Bilgisayar(string model)
        {
            Model = model;
            Islemci = new Islemci(4, 3200); // Bilgisayar yaratıldığında bir İşlemci de oluşturulur.
        }
    }
}