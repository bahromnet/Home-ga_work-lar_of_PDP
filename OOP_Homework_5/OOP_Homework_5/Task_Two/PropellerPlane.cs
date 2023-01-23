 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_Two
{
    internal class PropellerPlane : Aircraft
    {
        private int propellers;
        public int Propellers { get { return propellers; } set { propellers = value; } }


        public override string start()
        {
            throw new NotImplementedException();
        }
        public override string stop()
        {
            throw new NotImplementedException();
        }
        public override string takeoff()
        {
            throw new NotImplementedException();
        }
        public override string land()
        {
            throw new NotImplementedException();
        }
    }
}
