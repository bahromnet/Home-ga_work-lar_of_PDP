using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class Bird : Animal
    {
        private string lengthOfWing;
        private bool isFly;
        private string maxTall;
        public Bird(string lengthOfWing, bool isFly, string maxTall, int legs, string color, bool isBreastfeeding)
            : base(legs, color, isBreastfeeding)
        {
            this.lengthOfWing = lengthOfWing;
            this.isFly = isFly;
            this.maxTall = maxTall;
        }
        public string LengthOfWing
        {
            get { return lengthOfWing; }
            set { lengthOfWing = value; }
        }
        public bool IsFly
        {
            get { return isFly; }
            set { isFly = value; }
        }
        public string MaxTall
        {
            get { return maxTall; }
            set { maxTall = value; }
        }
        public string BirdInfo()
        {
            string s = isFly ? "Ucha oladi" : "Ucha olmaydi";
            string s2 = IsBreastfeeding ? "Sut emizuvchi" : "Sut emizuvchi emas";
            return $"Qanotlarini uzunligi : {lengthOfWing},\n{s},\nBo'yi : {maxTall},\nOyoqlari : {Legs} ta,\n" +
                $"Rangi : {Color},\n{s2}";
        }
    }
}
