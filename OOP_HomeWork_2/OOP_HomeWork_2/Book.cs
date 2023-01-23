using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HomeWork_2
{
    public class Book
    {
        public string[] bookName1
        {
            get
            {
                return bookName;
            }
        }
        private string[] bookName = 
            { 
            "Saodat asri qissalari", 
            "Atom odatlar", 
            "Ming quyosh shulasi", 
            "Katta O'yin" };

        public string[] bookAuthors1
        {
            get
            {
                return bookAuthors;
            }
        }
        private string[] bookAuthors =
            {"Ahmad Lutfiy Qozonchi",
            "James Clear, Polonchi, Pistonchi",
            "Xolid Husayniy",
            "Piter Hopkirk"
            };

        public long[] bookISBN1
        {
            get
            {
                return bookISBN;
            }
        }
        private long[] bookISBN =
        {
            012345689112,
            987654321000,
            000021123484,
            542223003985
        };

        public int[] bookPrices1
        {
            get
            {
                return bookPrices;
            }
        }
        private int[] bookPrices =
        {
            259_000,
            45_000,
            49_000,
            65_000,
        };

        public void GetInfo()
        {
            for (int i = 0; i < bookName.Length; i++)
            {
                Console.WriteLine($"Kitob nomi : {bookName1[i]}\nKitob avtorlari : {bookAuthors1[i]}");
                Console.WriteLine();
            }
        }
    }
}
