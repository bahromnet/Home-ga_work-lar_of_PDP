using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.Animals
{
    internal class Dog : Animal
    {
        protected override string makeSound()
        {
            return "bow-bow";
        }
    }
}
