using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_six
{
    internal class Fish : Animal, IPet
    {
        private string name;

        public Fish(string name, int legs) : base(legs)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void play()
        {
            Console.WriteLine("Played");
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public override string eat()
        {
            return base.eat();
        }
        public override string walk()
        {
            return base.walk();
        }
    }
}
