using OOP_Homework_7.Creatures;
using OOP_Homework_7.Task_one;

namespace OOP_Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Square square = new(8,18);
            //square = -square;
            //Console.WriteLine(square.ToString());
            //Square square1 = new(15, 22);
            //Square square2 = square1 - square;
            //Console.WriteLine(square2.ToString());


            Creature.Animals.Cat cat = new Creature.Animals.Cat();
            cat.Legs = 4;
            cat.Color = "Yellow";
            Console.WriteLine(cat.toFeed());


        }
    }
}