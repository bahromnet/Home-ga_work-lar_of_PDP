using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_five
{
    internal class Bar
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}


		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public Bar(string name, string address, string color)
		{
			this.name = name;
			this.address = address;
			this.color = color;
		}



	}
}
