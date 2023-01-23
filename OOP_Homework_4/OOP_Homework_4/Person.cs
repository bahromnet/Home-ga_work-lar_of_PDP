using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_4
{
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else Console.WriteLine("Error");
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string nationality;

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public Person(int Age, string Name, string Nationality)
        {
            this.Age = Age;
            this.Name = Name;
            this.Nationality = Nationality;
        }
        public static string Status(Person person)
        {
            if (person.Age > 0 && person.Age <= 12) return "Bola";
            else if (person.Age > 12 && person.Age <= 18) return "O'smir";
            else if (person.Age > 18 && person.Age <= 30) return "Yosh";
            else if (person.Age > 30 && person.Age <= 55) return "Voyaga yetgan";
            else if (person.Age > 55) return "Qari";
            return "";
        }

    }
}
