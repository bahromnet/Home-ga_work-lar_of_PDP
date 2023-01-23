using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_Two
{
    abstract class Aircraft
    {
        public string color;
        public object engine;

        public abstract string start();
        public abstract string stop();
        public abstract string takeoff();
        public abstract string land();
    }
}
