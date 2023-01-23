using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_four
{
    internal class Goalie : SoccerPlayer
    {
		private int goalsAllowed;
        public int GoalsAllowed
		{
			get { return goalsAllowed; }
			set { goalsAllowed = value; }
		}

		private double averageGoalsAllowed;

		public double AverageGoalsAllowed
		{
			get { return averageGoalsAllowed; }
			set { averageGoalsAllowed = value; }
		}


		public Goalie(int goalsAllowed, double averageGoalsAllowed, int minutes, int goals, string sport, string team, string position, string firstName, string lastName) 
            : base(minutes, goals, sport, team, position, firstName, lastName)
        {
            this.goalsAllowed = goalsAllowed;
			this.averageGoalsAllowed = averageGoalsAllowed;
        }


       


	}
}
