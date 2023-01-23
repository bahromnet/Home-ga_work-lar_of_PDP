using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_7.Creatures
{
    internal interface Creature
    {
        public abstract string toFeed();
        public abstract string growUp();
        public abstract string toBreathe();
        public abstract string toDie();
        internal abstract class Animals
        {
            private string color;

            public string Color
            {
                get { return color; }
                set { color = value; }  
            }


            private int legs;
            public int Legs
            {
                get { return legs; }
                set { legs = value; }
            }
            public class Cat : Animals, Creature
            {
                public string growUp()
                {
                    throw new NotImplementedException();
                }

                public string toBreathe()
                {
                    throw new NotImplementedException();
                }

                public string toDie()
                {
                    throw new NotImplementedException();
                }

                public string toFeed()
                {
                    return "Eating...";
                }
            }
            class Insects : Animals, Creature
            {
                public string growUp()
                {
                    throw new NotImplementedException();
                }

                public string toBreathe()
                {
                    throw new NotImplementedException();
                }

                public string toDie()
                {
                    throw new NotImplementedException();
                }

                public string toFeed()
                {
                    throw new NotImplementedException();
                }
            }
            class Fishes : Creature
            {
                public string growUp()
                {
                    throw new NotImplementedException();
                }

                public string toBreathe()
                {
                    throw new NotImplementedException();
                }

                public string toDie()
                {
                    throw new NotImplementedException();
                }

                public string toFeed()
                {
                    throw new NotImplementedException();
                }

            }
            class Birds : Animals, Creature
            {
                private int lengthOfWings;

                public int LengthOfWings
                {
                    get { return lengthOfWings; }
                    set { lengthOfWings = value; }
                }

                public class Eagle : Birds
                {

                }
                public string growUp()
                {
                    throw new NotImplementedException();
                }

                public string toBreathe()
                {
                    throw new NotImplementedException();
                }

                public string toDie()
                {
                    throw new NotImplementedException();
                }

                public string toFeed()
                {
                    throw new NotImplementedException();
                }
            }
        }
        public class Humans : Creature
        {
            public const int legs = 2, hands = 2, eyes = 2, head = 1;
            public string growUp()
            {
                throw new NotImplementedException();
            }

            public string toBreathe()
            {
                throw new NotImplementedException();
            }

            public string toDie()
            {
                throw new NotImplementedException();
            }

            public string toFeed()
            {
                throw new NotImplementedException();
            }
            class Male : Humans
            {
                
            }
            class Female : Humans
            {

            }
        }
        class Plants : Creature
        {
            public string growUp()
            {
                throw new NotImplementedException();
            }

            public string toBreathe()
            {
                throw new NotImplementedException();
            }

            public string toDie()
            {
                throw new NotImplementedException();
            }

            public string toFeed()
            {
                throw new NotImplementedException();
            }

        }
    }
}
