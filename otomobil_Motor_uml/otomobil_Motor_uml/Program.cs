using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomobil_Motor_uml
{
    class Motor
    {
        public int Guc { get; set; }
        public string Tip { get; set; }

        public Motor(int guc, string tip)
        {
            Guc = guc;
            Tip = tip;
        }

        public void MotorBilgisi()
        {
            Console.WriteLine($"Motor Gücü: {Guc} HP, Tip: {Tip}");
        }
    }

    class Otomobil
    {
        public string Marka { get; set; }
        public Motor Motor { get; set; }

        public Otomobil(string marka)
        {
            Marka = marka;
            Motor = new Motor(150, "Benzinli"); // Otomobil yaratıldığında bir Motor da oluşturulur.
        }
    }
}
