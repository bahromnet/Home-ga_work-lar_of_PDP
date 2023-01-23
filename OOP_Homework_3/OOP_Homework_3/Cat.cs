using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class Cat : Pet
    {
        public Cat(string laqabi, string benefit, int legs, string color, bool isBreastfeeding) 
            : base(laqabi, benefit, legs, color, isBreastfeeding) { }

        public string CatInfo()
        {
            return "Mushuk yaratildi";
        }
    }
}
