using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_three
{
    internal class HourlyEmployee : Employee
    {
        private int _hourlyRate;
        private int _jobId;
        public int HourlyRate { get { return _hourlyRate; } set { _hourlyRate = value; } }
        public int JobId { get { return _jobId; } set { _jobId = value; } }
        bool isHire = false;
        public HourlyEmployee(int hourlyRate, int jobId, string name, int age, string address, string hairColor,
            string eyeColor) : base(name, age, address, hairColor, eyeColor)
        {
            _hourlyRate = hourlyRate;
            _jobId = jobId;
        }

        public override string hire()
        {
            if (Age > 18)
            {
                return "Ishga qabul qilindi";
                isHire = true;
            }
            return "Ishga qabul qilinmadi";
        }

        public override string fire()
        {
            if (isHire) return "Ishdan bo'shatildi";
            return "Error";
        }
    }
}
