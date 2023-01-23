using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven
{
    internal class University
    {
        public string uName;
        public int id;
        public string getStipendiya()
        {
            return "Stipendiya berildi";
        }
        public University(string uName, int id)
        {
            this.uName = uName;
            this.id = id;
        }
        public string GetUnInfo()
        {
            return ($"{uName}, {id}");
        }
    }
}
