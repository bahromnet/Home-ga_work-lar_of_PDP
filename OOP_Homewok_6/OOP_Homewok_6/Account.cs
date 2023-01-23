using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homewok_6
{
    internal class Account
    {
        protected string id;
        protected Addres billing_address;
        protected bool is_Closed;
        protected DateTime open;
        protected DateTime closed;

        ShoppingCart shoppingCart = new ShoppingCart();
        Order order = new Order();

    }
}
