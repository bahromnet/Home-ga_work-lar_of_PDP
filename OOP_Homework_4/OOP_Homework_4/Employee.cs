using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_4
{
    internal class Employee : Student
    {
        private static int experience;
        public int Experience 
        { 
            get { return experience; } 
            set { experience = value; }
        }

        public Employee(string Degree, string Major, int Age, string Name, string Nationality, int Experience)
            : base(Degree, Major, Age, Name, Nationality)
        {
            this.Experience = Experience;
        }

        public static string GetDegree()
        {
            if (experience > 0 && experience <= 2) return "Junior";
            else if (experience > 2 && experience <= 4) return "Middle";
            else if (experience > 4 && experience <= 6) return "Senior";
            return "Team Leader";
        }
    }
}
