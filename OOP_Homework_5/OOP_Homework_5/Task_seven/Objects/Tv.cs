using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_seven.Objects
{
    internal class Tv : Electronics, IPult, ITechnique
    {
        public string changeChannal()
        {
            return "Channal changed";
        }

        public string changeSettings()
        {
            return "Settings changed";
        }

        public string changeVoice()
        {
            return "Volume changed";
        }

        

        public string repair()
        {
            return "TV repaired";
        }

        public string turnOff()
        {
            return "TV turned off";
        }

        public string turnOn()
        {
            return "TV turned on";
        }
    }
}
