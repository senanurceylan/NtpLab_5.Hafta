using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev_ve_Oda_uml
{
    class Oda
    {
        public string Boyut { get; set; }
        public string Tip { get; set; }

        public Oda(string boyut, string tip)
        {
            Boyut = boyut;
            Tip = tip;
        }

        public void OdaBilgisi()
        {
            Console.WriteLine($"Oda Boyutu: {Boyut}, Tip: {Tip}");
        }
    }

    class Ev
    {
        public string Ad { get; set; }
        public List<Oda> Odalar { get; set; } = new List<Oda>();

        public Ev(string ad)
        {
            Ad = ad;
        }

        public void OdaEkle(Oda oda)
        {
            Odalar.Add(oda);
        }
    }
}