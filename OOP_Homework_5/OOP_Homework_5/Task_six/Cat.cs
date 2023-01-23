using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_six
{
    internal class Cat : Animal, IPet
    {
        private string name;
        public Cat(string name, int legs) : base(legs)
        {
            this.name = name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void play()
        {
            throw new NotImplementedException();
        }
        public override string eat()
        {
            return base.eat();
        }
    }
}
