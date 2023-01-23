using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_four
{
    internal class Pitcher : BaseballPlayer
    {
        private double innings;

        public double Innings
        {
            get { return innings; }
            set { innings = value; }
        }

        private int earnedRuns;

        public int EarnedRuns
        {
            get { return earnedRuns; }
            set { earnedRuns = value; }
        }



        public Pitcher(double innings, int earnedRuns, int atBats, int hits, string sport, string team, string position, 
            string firstName, string lastName) 
            : base(atBats, hits, sport, team, position, firstName, lastName)
        {
            this.innings = innings;
            this.earnedRuns = earnedRuns;
        }

        public double earnedRunsAverage()
        {
            return (innings + earnedRuns) / 2;
        }
    }
}
