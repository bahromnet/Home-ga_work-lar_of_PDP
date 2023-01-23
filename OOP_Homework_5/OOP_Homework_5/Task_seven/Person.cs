using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven
{
    abstract class Person
    {
        protected string name;
        protected string surName;
        protected int age;
        protected Citizens citizen;

        public Person(string name, string surName, int age, Citizens citizen)
        {
            this.name = name;
            this.surName = surName;
            this.age = age;
            this.citizen = citizen;
        }
    }
}
