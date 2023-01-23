using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_four
{
    internal abstract class Player
    {
		private string sport;
		public string Sport
		{
			get { return sport; }
			set { sport = value; }
		}

		private string team;
		public string Team
		{
			get { return team; }
			set { team = value; }
		}

		private string position;
		public string Position
		{
			get { return position; }
			set { position = value; }
		}

		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public Player(string sport, string team, string position, string firstName, string lastName)
		{
			this.sport = sport;
			this.team = team;
			this.position = position;
			this.firstName = firstName;
			this.LastName = lastName;
		}



	}
}
