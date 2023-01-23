using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.Objects
{
    internal class Avto : ITechnique
    {
        public string repair()
        {
            return "Car repaired";
        }

        public string turnOff()
        {
            return "Car turned off";
        }

        public string turnOn()
        {
            return "Car turned on";
        }
    }
}
