using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_three
{
    internal abstract class Employee : Person
    {
        public abstract string hire();

        public abstract string fire();

        public Employee(string name, int age, string address, string hairColor, string eyeColor) 
            : base(name, age, address, hairColor, eyeColor) { }
    }
}
