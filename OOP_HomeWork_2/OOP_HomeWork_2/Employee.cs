using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeWork_2
{
    public class Employee
    {
        public string identityNumber1
        {
            get
            {
                if (identityNumber == "") return "0";
                return identityNumber;
            }
            set
            {
                while (value != "01234567891011" && value != "32165498710110" && value != "11109876543210")
                {
                    Console.WriteLine("Bizda bunday ishchi mavjud emas...");
                    Console.Write("Qaytadan kiriting : ");
                    value = Console.ReadLine()!;
                    Console.WriteLine();
                }
                identityNumber = value;
            }
        }
        private string identityNumber = "";
        public string fullName1
        {
            get
            {
                if (identityNumber == "01234567891011") return fullNameOne;
                else if (identityNumber == "32165498710110") return fullNameTwo;
                else if (identityNumber == "11109876543210") return fullNameThree;
                return "No Name";
            }
        }
        private string fullNameOne = "Polonchi Pistonchiyev";
        private string fullNameTwo = "Boltavoy";
        private string fullNameThree = "Kim Yun Jin";
        public double salary
        {
            get
            {
                if (identityNumber == "01234567891011") return salaryOne;
                else if (identityNumber == "32165498710110") return salaryTwo;
                else if (identityNumber == "11109876543210") return salaryThree;
                return 0;
            }
        }
        private double salaryOne = 2_355_784.125;
        private double salaryTwo = 5_648_784.125;
        private double salaryThree = 15_925_784.125;
        public void GetInfo() => Console.WriteLine($"Ism Familiya : {fullName1}\n" +
            $"Identifikatsiya raqami : {identityNumber1}\nIsh haqqi : {salary}");
    }
}
