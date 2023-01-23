using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_One
{
    abstract class Shape
    {
        public string color;
        public string getColor(string color)
        {
            return color;
        }
        public abstract double Area();
    }
}
