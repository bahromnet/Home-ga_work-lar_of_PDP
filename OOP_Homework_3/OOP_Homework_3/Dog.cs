using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class Dog : Pet
    {
        public Dog(string laqabi,  string benefit, int legs, string color, bool isBreastfeeding)
            : base(laqabi, benefit, legs, color, isBreastfeeding) { }

        public string DogInfo()
        {
            return "Kuchuk yaratildi";
        }
    }
}
