using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_six
{
    internal abstract class Animal
    {
        private int legs;
        public Animal(int legs)
        {
            this.legs = legs;
        }
        public virtual string walk()
        {
            return "walked";
        }
        public virtual string eat()
        {
            return "Yeding";
        }
    }
}
