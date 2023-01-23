using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.PerEmp
{
    internal class Student : Person
    {
        public University university;

        public Student(University university, string name, string surName, int age, Citizens citizen)
            : base(name, surName, age, citizen)
        {
            this.university = university;
        }
        public string GetInfo()
        {
            return $"{university.GetUnInfo()} \n{name} {surName} \n{age} \n{citizen}";
        }
    }
}
