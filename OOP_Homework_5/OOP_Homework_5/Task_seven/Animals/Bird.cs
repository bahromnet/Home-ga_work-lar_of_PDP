using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.Animals
{
    internal class Bird : Animal, ICanFly
    {
        public string fly()
        {
            throw new NotImplementedException();
        }

        public string land()
        {
            throw new NotImplementedException();
        }

        protected override string makeSound()
        {
            throw new NotImplementedException();
        }
    }
}
