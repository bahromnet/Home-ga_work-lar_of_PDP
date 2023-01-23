using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_One
{
    internal class Ractangle : Shape
    {
        private double length;
        private double width;
        public double Length { get { return length; } set { length = value; } }
        public double Width { get { return width; } set { width = value; } }

        public override double Area()
        {
            return length * width;
        }
    }
}
