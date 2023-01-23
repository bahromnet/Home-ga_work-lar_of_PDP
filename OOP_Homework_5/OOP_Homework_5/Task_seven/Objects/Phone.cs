using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.Objects
{
    internal class Phone : Electronics, ITechnique
    {
        public string repair()
        {
            return "Phone repaired";
        }

        public string turnOff()
        {
            return "Phone turned off";
        }

        public string turnOn()
        {
            return "Phone turned on";
        }
    }
}
