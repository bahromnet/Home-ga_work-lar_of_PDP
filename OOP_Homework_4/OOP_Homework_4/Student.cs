using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_4
{
    public class Student : Person
    {
        public string Degree { get; set; }
        public string Major { get; set; }

        //public Student(string Degree, string Major, int Age, string Name, string Nationality) : base(Age, Name, Nationality)
        //{
        //    this.Major = Major;
        //    this.Degree = Degree;
        //}
        //public Student()
        //{

        //}
        public Student(string Degree, string Major, int Age, string Name, string Nationality) 
            : base(Age, Name, Nationality)
        {
            this.Age = Age;
            this.Major = Major;
            this.Nationality = Nationality;
            this.Nationality = Nationality;
            this.Degree = Degree;
        }
    }
}
