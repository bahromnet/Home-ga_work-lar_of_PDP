using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class PaperBooks : Book
    {
        private double weight;
        private int deliveryTime;

        public PaperBooks(double weight, int deliveryTime) : base()
        {
            this.weight = weight;
            this.deliveryTime = deliveryTime;
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int DeliveryTime
        {
            get { return deliveryTime; }
            set { deliveryTime = value;}
        }
    }
}
