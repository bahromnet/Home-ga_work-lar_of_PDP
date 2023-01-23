using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class Animal
    {
        private int legs;
        private string color;
        private bool isBreastfeeding;

        public Animal(int legs, string color, bool isBreastfeeding)
        {
            this.legs = legs;
            this.color = color;
            this.isBreastfeeding = isBreastfeeding;
        }

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool IsBreastfeeding
        {
            get { return isBreastfeeding; }
            set { isBreastfeeding = value; }
        }
    }
}
