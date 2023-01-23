using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_4
{
    internal class Book
    {
		private int numberOfPages;

		public int NumberOfPages
        {
			get { return numberOfPages; }
			set 
			{
				if (value < 0) Console.WriteLine("Error");
				else numberOfPages = value;
            }
		}
		public Book(int NumberOfPages)
		{
			this.NumberOfPages = NumberOfPages;
		}
		public static string TypeOfBook(Book book)
		{
			if (book.NumberOfPages <= 200) return "Kichik";
			else if (book.NumberOfPages > 200 && book.NumberOfPages <= 400) return "O'rta";
			else if (book.NumberOfPages > 400 && book.NumberOfPages <= 800) return "Katta";
			return "Mega";
		}

	}
}
