using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeWork_2
{
    public class AccountFive
    {
        public double balance1
        {
            get
            {
                return balance;
            }
            set
            {
                balance = checkBalance(value);
            }
        }
        private double balance = 0;

        public string accountNumber1
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = checkAccountNumber(value);
            }
        }
        private string accountNumber = "0123456789101234";

        public string userName1
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        private string userName = "Teshavoy";

        public string password1
        {
            get
            {
                return password;
            }
            set
            {
                
                password = checkPass(value);
            }
        }
        private string password = "12345678";

        public string name1
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string name = "Boltavoy";

        public void GetInfo()
        {
            Console.WriteLine($"Ism : {name1}\nUsername : {userName1}\nParol : {password1}\n" +
                $"Hisob Raqami : {accountNumber1}\nBalans : {balance1}");
        }


        // -------------Funcsions-----------------
        static string checkAccountNumber(string s)
        {
            bool isNumber = false;
            while (!isNumber || s.Length != 16)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if ((int)s[i] >= 48 && (int)s[i] <= 57)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        isNumber = false;
                        break;
                    }
                }
                if (!isNumber || s.Length < 16 || s.Length > 16)
                {
                    Console.Write("Hisob raqami noto'g'ri, qaytadan kiriting : ");
                    s = Console.ReadLine()!;
                    Console.WriteLine();
                }
            }
            return s;
        }

        public double checkBalance(double balance)
        {
            while (balance < 0)
            {
                Console.Write("Balansga qayta qiymat kiriting : ");
                balance = double.Parse(Console.ReadLine()!);
                Console.WriteLine();
            }
            return balance;

        }

        public string checkPass(string pass)
        {
            string newPass = "";
            while (pass != password)
            {
                Console.Write("Eski parol noto'g'ri kiritildi,\nQaytadan kiriting : ");
                newPass = Console.ReadLine()!;
                pass = newPass;
                Console.WriteLine();
            }
            pass = newPass;
            while (pass.Length < 8)
            {
                Console.WriteLine("Parolda kamida 8 ta belgi bo'lishi kerak...");
                pass = Console.ReadLine()!;
                Console.WriteLine();
            }
            return pass;
        }
    }
}
