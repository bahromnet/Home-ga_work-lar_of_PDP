using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_1
{
    public class Triangel
    {
        public double katetBir;
        public double katetIkki;

        public Triangel(double katetBir, double katetIkki)
        {
            this.katetBir = katetBir;
            this.katetIkki = katetIkki;
        }

        
        public void Perimetr()
        {
            double gipotenuza = Math.Sqrt(katetBir * katetBir + katetIkki * katetIkki);
            Console.WriteLine(katetBir+katetIkki+gipotenuza);
        }
        public void Yuza()
        {
            Console.WriteLine((katetBir*katetIkki)/2);
        }
    }
}
