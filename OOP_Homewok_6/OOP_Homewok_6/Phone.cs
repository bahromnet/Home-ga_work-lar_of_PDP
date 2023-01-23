using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homewok_6
{
    internal class Phone
    {
		private string phoneNumber = "+998 ";

		public string PhoneNumber
		{
			get 
			{ 
				return phoneNumber; 
			}
			set 
			{
				phoneNumber += number(value); 
			}
		}	

		public string number(string n)
		{
			while (n.Length != 9 )
			{
				Console.WriteLine("Noto'gri qiymat kiritildi, qaytadan kiriting...");
				Console.Write("+998 ");
				n = Console.ReadLine()!;
			}
            bool isNum = false;
            while (!isNum)
			{
                for (int i = 0; i < n.Length; i++)
                {
                    if ((int)n[i] >= 48 && (int)n[i] <= 57)
                    {
                        isNum = true;
                    }
                    else
                    {
                        isNum = false;
                        break;
                    }
                }
                if (isNum) return n;
                return "";
            }
			return "";
		}

	}
}
