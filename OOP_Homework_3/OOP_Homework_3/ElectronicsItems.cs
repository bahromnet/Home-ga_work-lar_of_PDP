using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class ElectronicsItems
    {
        private string processor;
        private string memory;
        private string operativca;
        private string monitor;
        private string sound;
        public string Processor
        {
            get { return processor; }
            set { processor = value; }
        }
        public string Memory
        {
            get { return memory; }
            set { memory = value; }
        }
        public string Operativca
        {
            get { return operativca; }
            set { operativca = value; }
        }
        public string Monitor
        {
            get { return monitor; }
            set { monitor = value; }
        }
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
    }
}
