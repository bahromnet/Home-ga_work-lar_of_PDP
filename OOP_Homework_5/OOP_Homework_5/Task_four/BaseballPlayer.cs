using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_5.Task_four
{
    internal class BaseballPlayer : Player
    {
        private int atBats;

        public int AtBats
        {
            get { return atBats; }
            set { atBats = value; }
        }

        private int hits;

        public int Hits
        {
            get { return hits; }
            set { hits = value; }
        }


        public BaseballPlayer(int atBats, int hits, string sport, string team, string position, string firstName, string lastName) 
            : base(sport, team, position, firstName, lastName)
        {
            this.atBats = atBats;
            this.hits = hits;
        }

        public double battingAvarage()
        {
            return (atBats + hits) / 2;
        }

    }
}
