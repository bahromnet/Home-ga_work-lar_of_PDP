using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven
{
    abstract class Employee : Person
    {
        protected double salary;

        protected Employee(double salary, string name, string surName, int age, Citizens citizen) 
            : base(name, surName, age, citizen)
        {
            this.salary = salary;
        }
    }
}
