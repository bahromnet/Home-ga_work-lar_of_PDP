using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_4
{
    static class MyString
    {
        private static string satr;
        public static string Satr 
        { 
            get { return satr; }
            set { satr = value; }
        }
        public static void BigLetter()
        {
            string newSatr = "";
            for (int i = 1; i < satr.Length; i++)
            {
                if (i-1 == 0 && satr[i - 1] != ' ' && (int)satr[i] >= 97 && (int)satr[i] <= 122)
                {
                    newSatr += Convert.ToChar((int)satr[i] - 32).ToString();
                }
                else if (!(((int)satr[i-1] >= 97 && (int)satr[i - 1] <= 122) || ((int)satr[i-1] >= 65 && (int)satr[i-1] <= 90)) 
                    && (int)satr[i] >= 97 && (int)satr[i] <= 122)
                {
                    newSatr += Convert.ToChar((int)satr[i] - 32).ToString();
                }
                else
                {
                    newSatr += satr[i];
                }
                
            }
            Console.WriteLine(newSatr);
        }

        public static void MaxLength()
        {
            string[] s = satr.Split(" ");
            string max = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            Console.WriteLine(max);
        }

        public static void Probel()
        {
            string str = "";
            int j = 0;
            for (int i = 0; i < satr.Length; i++)
            {
                if (satr[i] != ' ')
                {
                    str += satr[i];
                    j++;
                }
                else
                {
                    if (j != 0 && str[j - 1] != ' ')
                    {
                        str += satr[i];
                        j++;
                    }
                }
            }
            Console.WriteLine(str);
        }
    }
}
