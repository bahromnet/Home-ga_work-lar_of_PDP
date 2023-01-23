using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.PerEmp
{
    internal class Programmer : Employee
    {
        public Programmer(double salary, string name, string surName, int age, Citizens citizen) 
            : base(salary, name, surName, age, citizen)
        {
        }
    }
}
