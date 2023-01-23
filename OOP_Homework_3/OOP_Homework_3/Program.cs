namespace OOP_Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region bir
            //Book book = new();
            //Console.Write("Nechta xarid qilmoqchisiz? ");
            //int n = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("Kitobning umumiy narxi : " + book.SalePrice(book.Price, n));
            //Console.WriteLine("Bojxona solig'i : " + book.CustomsDuty(book.Price, n));
            //Console.WriteLine();


            //EBook eBook = new("polonchi.com", 25);
            //Console.WriteLine("Kitobning nomi : " + eBook.PrintTitle());
            #endregion

            #region ikki

            #endregion

            #region uch

            #endregion

            #region tort
            //Cat cat = new("Momiqvoy", "Non", 4, "Sariq", true);
            //Console.WriteLine($"{cat.PatInfo()}\n\n{cat.CatInfo()}");
            //Console.WriteLine("\n");

            //Dog dog = new("Bo'bik", "Uyni himoya qiladi", 4, "Qora", true);
            //Console.WriteLine($"{dog.PatInfo()}\n\n{dog.DogInfo()}");
            //Console.WriteLine("\n");

            //Cow cow = new("Masha", "Sut va Gosht beradi", 4, "Ola-bula", true);
            //Console.WriteLine($"{cow.PatInfo()}\n\n{cow.CowInfo()}");
            //Console.WriteLine("\n");

            //Straus straus = new("1.5 m", false, "2.5 m", 2, "qora", false);
            //Console.WriteLine($"{straus.BirdInfo()},\n\n{straus.StrausInfo()}");
            //Console.WriteLine("\n");

            //Bat bat = new("35 sm", true, "25 sm", 2, "Jigarrang", true);
            //Console.WriteLine($"{bat.BirdInfo()}\n\n{bat.BatInfo()}");
            //Console.WriteLine("\n");

            //Eagle eagle = new("2.5 m", true, "70 sm", 2, "Qora", false);
            //Console.WriteLine($"{eagle.BirdInfo()}\n\n{eagle.EagleInfo()}");
            //Console.WriteLine("\n");
            #endregion

            Student student = new("Oliy", "Nimadur", 25, "Boltavoy");
            student.StudentInfo();
            Console.WriteLine();
            Student student2 = new("O'rat", "non");
            student2.StudentInfo();
            Console.WriteLine();
            student2.Age = 38;
            student2.Name = "Polvonali";
            student2.StudentInfo();
        }
        public class Person
        {
            private int age;

            public int Age
            {   
                get { return age; }
                set { age = value; }
            }

            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public Person(int Age, string Name)
            {
                this.Age = Age;
                this.Name = Name;
            }
            public Person()
            {
                age = 20;
                name = "Polonchi";
            }

            //public void PersonInfo()
            //{
            //    Console.WriteLine(age);
            //}

        }

        public class Student : Person
        {
            private string degree;

            public string Degree
            {
                get { return degree; }
                set { degree = value; }
            }
            private string major;

            public string Major
            {
                get { return major; }
                set { major = value; }
            }
            public Student(string degree, string major, int age, string name) : base(age, name)
            {
                this.degree = degree;
                this.major = major;
            }

            public Student(string Degree, string Major): base()
            {
                this.Degree = Degree;
                this.Major = Major;
            }

            public void StudentInfo()
            {
                Console.WriteLine($"{Name}, {Age}, {degree}, {major}");
            }
        }
    }
}
    