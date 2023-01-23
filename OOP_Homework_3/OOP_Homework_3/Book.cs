using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class Book
    {
        private string avtor;
        private double price;
        private double discount;
        private string title;
        private int numberOfPages;

        public Book() : this(12000, 0.05)
        {

        }
        public Book(double price, double discount) : this("Atomic Hebits", "James Clear", 232)
        {
            this.price = price;
            this.discount = discount;
        }
        public Book(string title, string avtor, int numberOfPages)
        {
            this.title = title;
            this.avtor = avtor;
            this.numberOfPages = numberOfPages;
        }
        public string Avtor
        {
            get { return avtor; }
            set { avtor = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }



        public double SalePrice(double price, int numer)
        {
            return price * numer;
        }
        public double CustomsDuty(double price, int numer)
        {
            return (price * numer) * 0.3;
        }
    }
}
