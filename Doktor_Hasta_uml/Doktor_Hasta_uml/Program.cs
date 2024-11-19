using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doktor_Hasta_uml
{
    class Hasta
    {
        public string Ad { get; set; }
        public string TCNo { get; set; }
        public Doktor Doktor { get; set; }

        public Hasta(string ad, string tcNo)
        {
            Ad = ad;
            TCNo = tcNo;
        }

        public void DoktorAtama(Doktor doktor)
        {
            if (Doktor != doktor)
            {
                Doktor = doktor;
                doktor.HastaEkle(this);
            }
        }
    }

    class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();

        public Doktor(string ad, string brans)
        {
            Ad = ad;
            Brans = brans;
        }

        public void HastaEkle(Hasta hasta)
        {
            if (!Hastalar.Contains(hasta))
            {
                Hastalar.Add(hasta);
                hasta.DoktorAtama(this);
            }
        }
    }