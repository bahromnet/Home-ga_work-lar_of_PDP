using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_7.Task_one
{
    internal class Square
    {
		private int sideA;
		public int SideA
		{
			get { return sideA; }
			private set { sideA = value; }
		}

		private int sideB;
		public int SideB
		{
			get { return sideB; }
			private set { sideB = value; }
		}
		public Square()
		{

		}

		public Square(int sideA, int sideB)
		{
			this.sideA = sideA;
			this.sideB = sideB;
		}
		public void showSquare()
		{
			Console.WriteLine(sideA + ", " + sideB);
		}

		public static Square operator -(Square s)
		{
			s.sideA -= 5;
			s.sideB -= 5;
			return s;
		}
		public static Square operator -(Square a, Square b)
		{
			Square square = new Square();
			square.sideA = Math.Abs(a.sideA - b.sideA);
			square.sideB = Math.Abs(a.sideB - b.sideB);
			return square;
		}
        public static Square operator --(Square c)
        {
            c.sideA--;
            c.sideB--;
            return c;
        }
		public static Square operator ++(Square p1)
		{
			p1.SideA++;
			p1.sideB++;
			return p1;
		}
		public static Square operator +(Square p2, Square p3)
		{
			Square square = new();
			square.sideA = p2.sideA + p3.sideA;
			square.sideB = p2.sideB + p3.sideB;
			return square;
		}
		//public static Square operator /(Square devide1)
		//{
		//	Square square = new Square();
		//	devide1.sideA /= 2;
		//	devide1.sideB /= 2;
		//	return devide1;
		//}
        public static Square operator /(Square devide1, Square devide2)
        {
			Square square = new Square();
			square.sideA = devide1.sideA / devide2.sideA;
			square.sideB = devide1.sideB / devide2.sideB;
            return square;
        }
		public static bool operator <=(Square s1, Square s2)
		{
			return (s1.sideA <= s2.sideA) & (s1.sideB <= s2.sideB);
		}
        public static bool operator >=(Square s1, Square s2)
        {
            return (s1.sideA >= s2.sideA) & (s1.sideB >= s2.sideB);
        }

		public override bool Equals(object? obj)
		{
			if ((((Square)obj!).sideA == this.sideA) && ((Square)obj).sideB == this.sideB)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public override int GetHashCode()
        {
			return this.ToString().GetHashCode();
        }
		public static bool operator ==(Square z1, Square z2)
		{
			return z1.Equals(z2);
		}
		public static bool operator !=(Square z1, Square z2)
		{
			return !z1.Equals(z2);
		}
		public override string ToString()
		{
			return $"A->{sideA}, B->{sideB}";
        }
    }
}
