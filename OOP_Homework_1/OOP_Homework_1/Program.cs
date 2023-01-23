namespace OOP_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region bir
            //int x = int.Parse(Console.ReadLine()!);
            //int y = int.Parse(Console.ReadLine()!);
            //Point point = new(x, y);
            //point.PrintXY();
            #endregion

            #region ikki
            //double a = double.Parse(Console.ReadLine()!);
            //double b = double.Parse(Console.ReadLine()!);
            //Triangel triangel = new(a, b);
            //triangel.Perimetr();
            //triangel.Yuza();
            #endregion

            #region uch
            //int a = int.Parse(Console.ReadLine()!);
            //int b = int.Parse(Console.ReadLine()!);
            //MyClass myClass = new(a, b);
            //myClass.AboutFields();
            //int sum = myClass.SumOfFields();
            //Console.WriteLine(sum);
            //int max = myClass.MaxField();
            //Console.WriteLine(max);
            #endregion

            #region tort
            //int year = DateTime.Now.Year;
            //int month = DateTime.Now.Month;
            //int day = DateTime.Now.Day;
            //MyDate myDate = new(year, month, day);
            //myDate.PrintDate();
            #endregion




            #region besh
            string surname = Console.ReadLine()!;
            string name = Console.ReadLine()!;
            int group_ID = int.Parse(Console.ReadLine()!);
            string[] subjects = new string[5];
            for (int i = 0; i < 5; i++)
            {
                subjects[i] = Console.ReadLine()!;
            }
            Student student = new Student(surname, name, group_ID, subjects);
            student.PrintSubject();
            #endregion
        }
    }
}