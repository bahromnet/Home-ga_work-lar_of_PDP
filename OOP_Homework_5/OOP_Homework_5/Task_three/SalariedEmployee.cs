using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_three
{
    internal class SalariedEmployee : Employee, IOffice
    {
        private double weeklyPay;
        public double WeeklyPay { get { return weeklyPay; } set { weeklyPay = value; } }
        public SalariedEmployee(double weeklyPay, string name, int age, string address, string hairColor,
            string eyeColor) : base(name, age, address, hairColor, eyeColor)
        {
            this.weeklyPay = weeklyPay;
           
        }
        bool isHire = false;
        public override string hire()
        {
            if (Age > 18)
            {
                return $"{Name} ishga qabul qilindi";
                isHire = true;
            }
            return $"{Name} ishga qabul qilinmadi";
        }

        public override string fire()
        {
            if (isHire) return $"{Name} ishdan bo'shatildi";
            return "Error";
        }

        public void SetOccupant(string occupant)
        {
            throw new NotImplementedException();
        }
        public void SetNumber(int number)
        {
            throw new NotImplementedException();
        }

        public string GetOccupant()
        {
            throw new NotImplementedException();
        }
        public int GetNumber()
        {
            throw new NotImplementedException();
        }
    }
}
