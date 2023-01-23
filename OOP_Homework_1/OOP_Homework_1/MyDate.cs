using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_1
{
    public class MyDate
    {
        public int year;
        public int month;
        public int day;

        public MyDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public void PrintDate()
        {
            Console.WriteLine($"{day}.{month}.{year}");
        }
    }
}
