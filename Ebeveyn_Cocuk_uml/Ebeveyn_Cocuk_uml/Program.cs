using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebeveyn_Cocuk_uml
{
    class Cocuk
    {

        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; set; }

        public Cocuk(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public void EbeveynAtama(Ebeveyn ebeveyn)
        {
            if (Ebeveyn != ebeveyn)
            {
                Ebeveyn = ebeveyn;
                ebeveyn.CocukEkle(this);
            }
        }
    }

    class Ebeveyn
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Cocuk> Cocuklar { get; set; } = new List<Cocuk>();

        public Ebeveyn(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public void CocukEkle(Cocuk cocuk)
        {
            if (!Cocuklar.Contains(cocuk))
            {
                Cocuklar.Add(cocuk);
                cocuk.EbeveynAtama(this);
            }
        }
    }
}