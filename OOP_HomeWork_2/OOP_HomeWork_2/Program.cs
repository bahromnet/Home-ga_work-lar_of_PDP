namespace OOP_HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region bir
            //int soat = DateTime.Now.Hour;
            //int minut = DateTime.Now.Minute;
            //int sekund = DateTime.Now.Second;
            //int soat = int.Parse(Console.ReadLine());
            //int minut = int.Parse(Console.ReadLine()!);
            //int sekund = int.Parse(Console.ReadLine()!);
            //Time time = new(soat, minut, sekund);
            //time.GetTimeInfo();
            #endregion

            #region ikki
            //Console.Write("Hisob raqamingizni kiriting : ");
            //string number = Console.ReadLine()!;
            //Console.WriteLine();
            //Account account = new();
            //account.AccountNumber1 = number;
            //account.GetInfo();
            #endregion

            #region uch
            //Console.Write("Identificatsiya raqamingizni kiriting : ");
            //string indetityNumber = Console.ReadLine()!;
            //Console.WriteLine();
            //Employee employee = new();
            //employee.identityNumber1 = indetityNumber;
            //employee.GetInfo();
            #endregion

            #region tort
            //Book book = new ();
            //book.GetInfo();
            #endregion

            #region besh
            //AccountFive accountFive = new AccountFive();
            //accountFive.GetInfo();
            //Console.Write("Eski parolni kiriting : ");
            //string pass = Console.ReadLine()!;
            //accountFive.password1 = pass;
            //Console.Write("Ismni kiriting : ");
            //string name = Console.ReadLine()!;
            //Console.Write("Usernameni kiriting : ");
            //string userName = Console.ReadLine()!;
            //Console.Write("balansni kiriting : ");
            //double balans = double.Parse(Console.ReadLine()!);
            //Console.Write("Hisob raqamni kiriting : ");
            //string accountNumber = Console.ReadLine()!;
            //accountFive.name1= name;
            //accountFive.userName1 = userName;
            //accountFive.balance1 = balans;
            //accountFive.accountNumber1 = accountNumber;
            //accountFive.GetInfo();
            #endregion

            Student student1 = new Student();


        }

        public class Person
        {
            private string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            private int age;
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }

            public Person()
            {
                Console.WriteLine("Empty Constructor");
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }


        }
        public class Student : Person
        {
            public Student() : this("Boltavoy", 56)
            {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
            }

            public Student(string name, int age) : base(name, age)
            {
                Console.WriteLine("Lalalalalaaa");
            }
        }
    }
}