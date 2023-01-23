using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_1
{
    public class MyClass
    {
        public int first;
        public int second;

        public MyClass(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public void AboutFields()
        {
            Console.WriteLine($"{first}, {second}");
        }

        public int SumOfFields()
        {
            int sum = first + second;
            return sum;
        }

        public int MaxField()
        {
            int max = second;
            if (first > second) max = first;
            return max;
        }
    }
}
