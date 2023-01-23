using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homewok_6
{
    internal class Order
    {
        public string number;
        public DateTime oredered;
        public DateTime shipped;
        public Addres ship_to;
        public OrderStatus status;
        public double total;

    }
}
