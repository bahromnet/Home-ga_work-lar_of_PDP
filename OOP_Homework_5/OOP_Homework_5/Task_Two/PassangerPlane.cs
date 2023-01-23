using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_Two
{
    internal class PassangerPlane : Aircraft
    {
        private int passengers;
        public int Passengers { get { return passengers; } set { passengers = value; } }

        public override string start()
        {
            return "Plane Started";
        }
        public override string stop()
        {
            return "Plane Stopped";
        }
        public override string takeoff()
        {
            return "Plane taked off";
        }
        public override string land()
        {
            return "Plane landed";
        }
    }
}
