using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_four
{
    internal class SoccerPlayer : Player
    {
        private int minutes;

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        private int goals;

        public int Goals
        {
            get { return goals; }
            set { goals = value; }
        }


        public SoccerPlayer(int minutes, int goals, string sport, string team, string position, string firstName, string lastName) 
            : base(sport, team, position, firstName, lastName)
        {
            this.minutes = minutes;
            this.goals = goals;
        }

        public double goalsPerGame()
        {
            return goals;
        }
    }
}
