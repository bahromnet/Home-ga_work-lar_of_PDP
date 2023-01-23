using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_five
{
    internal class Foo : Bar, Fizz
    {
        private string pivo;

        public string Pivo
        {
            get { return pivo; }
            set { pivo = value; }
        }

        private string water;

        public string Water
        {
            get { return water; }
            set { water = value; }
        }

        private string hotDog;

        public string HotDog
        {
            get { return hotDog; }
            set { hotDog = value; }
        }

        private string rolton;

        public string Rolton
        {
            get { return rolton; }
            set { rolton = value; }
        }





        public Foo(string pivo, string water, string hotDog, string rolton, string name, string address, string color) 
            : base(name, address, color)
        {
            this.pivo = pivo;
            this.water = water;
            this.hotDog = hotDog;
            this.rolton = rolton;
        }

        public string getInfo(string name)
        {
            throw new NotImplementedException();
        }
    }
}
