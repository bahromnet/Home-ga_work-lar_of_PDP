using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.Objects
{
    internal class Plane : ITechnique, ICanFly
    {
        public string fly()
        {
            return "The Plane took off";
        }

        public string land()
        {
            return "The plane landed on the ground";
        }


        public string repair()
        {
            return "The plane repaired";
        }

        public string turnOff()
        {
            return "The plane turned off";
        }

        public string turnOn()
        {
            return "The plane turned on";
        }
    }
}
