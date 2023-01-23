using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_Two
{
    internal class FighterPlane : Aircraft
    {
        private object engine;
        public object Engine { get { return engine; } set { engine = value; } }

        public override string start()
        {
            return "Fighter plane started";
        }
        public override string stop()
        {
            return "Fighter plane stopped";
        }
        public override string takeoff()
        {
            return "Fighter plane teked off";
        }
        public override string land()
        {
            return "Fighter plane landed";
        }
    }
}
