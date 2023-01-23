using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class Pet : Animal
    {
        private string laqabi;
        private string benefit;
        public string Laqabi
        {
            get { return laqabi; }
            set { laqabi = value; }
        }
        public string Benefit
        {
            get { return benefit; }
            set { benefit = value; }
        }
        public Pet(string laqabi, string benefit, int legs, string color, bool isBreastfeeding)
            : base(legs, color, isBreastfeeding)
        {
            this.laqabi = laqabi;
            this.benefit = benefit;
        }
        public string PatInfo()
        {
            string s = IsBreastfeeding ? "Sut emizuvchi" : "Sut emizuvchi emas";
            return $"Laqabi : {laqabi},\nFoydasi : {benefit},\nOyoqlari soni : {Legs},\n" +
            $"Rangi : {Color},\n{s}";
        }
    }
}
