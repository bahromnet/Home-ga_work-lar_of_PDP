using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_three
{
    internal interface IPerson
    {
        public void SetName(string name);
        public void NewAdress(string address);
    }

    abstract class Person : IPerson
    {
        private string name;
        private int age;
        private string address;
        private string hairColor;
        private string eyeColor;
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public string Address { get { return address; } }
        public string HairColor { get { return hairColor; } set { hairColor = value; } }
        public string EyeColor { get { return eyeColor; } set { eyeColor = value; } }
        public Person(string name, int age, string address, string hairColor, string eyeColor)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
        }

        public void NewAdress(string newAddress)
        {
            address = newAddress;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }
}
