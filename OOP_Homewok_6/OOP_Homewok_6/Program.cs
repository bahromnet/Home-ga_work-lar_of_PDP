namespace OOP_Homewok_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Phone p = new Phone();
            //Console.Write(p.PhoneNumber);
            //string a = Console.ReadLine()!;
            //p.PhoneNumber = a;
            //Console.WriteLine(p.PhoneNumber);


            Triangel triangel = new Triangel(10, 20, 25);
            Console.WriteLine(triangel.showItems());
            Triangel triangel1 = new Triangel();
            triangel1 = -triangel;
            Console.WriteLine(triangel1.showItems());

            Console.WriteLine("=================");

            TriangelTwo triangelTwo = new TriangelTwo(3,4,5);
            Console.WriteLine(triangelTwo.getInfo());
            TriangelTwo triangelTwo2 = new TriangelTwo(6, 8, 10);
            Console.WriteLine(triangelTwo2.getInfo());
            TriangelTwo triangelTwo3 = new TriangelTwo();
            triangelTwo3 = triangelTwo + triangelTwo2;
            Console.WriteLine(triangelTwo3.getInfo());

            Console.WriteLine("=================");



        }

        class Triangel
        {
            private int a; 
            private int b; 
            private int c;

            public Triangel()
            {

            }

            public Triangel(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public string showItems()
            {
                return $"{a}, {b}, {c}";
            }

            public static Triangel operator -(Triangel x)
            {
                Triangel temp = new Triangel();
                temp.a = -x.a;
                temp.b = -x.b;
                temp.c = -x.c;
                return temp;
            }
        }

        class TriangelTwo
        {
            private int a;
            private int b;
            private int c;

            public TriangelTwo() { }

            public TriangelTwo(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public string getInfo()
            {
                return $"{a}, {b}, {c}";
            }
            public static TriangelTwo operator +(TriangelTwo x, TriangelTwo y)
            {
                TriangelTwo triangelTwo = new TriangelTwo();
                triangelTwo.a = x.a + y.a;
                triangelTwo.b = x.b + y.b;
                triangelTwo.c = x.c + y.c;
                return triangelTwo;
            }
        }

        class TriangelThree
        {
            private int a;
            private int b;
            private int c;

            public TriangelThree() { }

            public TriangelThree(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public string getInfo()
            {
                return $"{a}, {b}, {c}";
            }
            //public override bool smallOrEquals(Object o)
            //{
            //    if ((TriangelThree)o)
            //}
        }


        
    }
}