using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_4
{
    internal class Shape
    {
        public virtual void Draw()
        {
            Console.Write("CHizildi !");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.Write("Uchburchak");
            base.Draw();
        }

    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.Write("Kvadrat !");
            base.Draw();
        }
    }
}
