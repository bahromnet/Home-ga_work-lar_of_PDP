using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_three
{
    internal interface IOffice
    {
        public void SetNumber(int number);
        public int GetNumber();
        public void SetOccupant(string occupant);
        public string GetOccupant();
    }
}
