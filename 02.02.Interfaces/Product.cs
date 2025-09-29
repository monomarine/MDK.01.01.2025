using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
	internal class Product
	{
		public string Name { get; set; } = "";
		public int Price { get; set; }

		public static bool operator >(Product left, Product right)
		{
			return left.Price > right.Price;
		}

		public static bool operator <(Product left, Product right)
		{
			return left.Price < right.Price;
		}

		public static int operator +(Product left, Product right)
		{
			return left.Price + right.Price;
		}

		public static int operator -(Product left, Product right)
		{
			return left.Price - right.Price;
		}

		public override string ToString()
		{
			return $"Товар: {Name} Цена: {Price} рублей";
		}
	}
}
