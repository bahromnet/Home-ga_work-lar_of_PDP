using OOP_Homework_5.Task_One;
using OOP_Homework_5.Task_seven;
using OOP_Homework_5.Task_seven.PerEmp;

namespace OOP_Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Circle circle = new Circle();
            //circle.Radius = 2;
            //Console.WriteLine(circle.Area());
            #endregion

            #region task7
            University university = new University("Tatu", 123);
            Student student = new (university, "Boltavoy", "Plvonali", 12, Citizens.Uzbekistan);
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(student.university.getStipendiya());
            #endregion
        }
    }
}