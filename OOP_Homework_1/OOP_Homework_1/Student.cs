using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_1
{
    public class Student
    {
        public string surname;
        public string name;
        public int group_Id;
        public string[] subjects;

        public Student(string surname, string name, int group_Id, string[] subjects)
        {
            this.surname = surname;
            this.name = name;
            this.group_Id = group_Id;
            this.subjects = subjects;
        }

        public void PrintSubject()
        {
            foreach (string item in subjects)
            {
                Console.Write(item +" ");
            }
        }
    }
}
