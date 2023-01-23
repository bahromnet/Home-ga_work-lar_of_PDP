using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_One
{
    internal class Circle : Shape   
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
