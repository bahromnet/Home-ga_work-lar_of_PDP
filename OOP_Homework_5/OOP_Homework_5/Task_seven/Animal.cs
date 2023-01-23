using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven
{
    abstract class Animal
    {
        protected int legs;
        protected string color;
        protected const int eye = 2;
        protected abstract string makeSound();
    }
}
