using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homewok_6
{
    internal abstract class Customer : WebUser
    {
        public string id;
        public Addres address;
        public Phone phone;
        public string email;

        Account account = new Account();

    }
}
