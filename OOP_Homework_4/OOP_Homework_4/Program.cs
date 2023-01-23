namespace OOP_Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region bir
            MyString.Satr = "   Using    char    struct    (to  string    and back  again) ";
            MyString.Probel();
            #endregion

            #region ikki
            //Person person = new(13, "Boltavoy", "UZB");
            //Console.WriteLine(Person.Status(person));
            //Console.WriteLine();
            //Employee employee = new("Oliy", "Major", 25, "Boltavoy", "Andijan", 2);
            //Console.WriteLine(Employee.GetDegree());
            //Console.WriteLine();

            #endregion
            Shape shape=new Shape();

            Triangle triangle = new();
            triangle.Draw();

            Square square = new Square();
            square.Draw();
            
        }
    }
}