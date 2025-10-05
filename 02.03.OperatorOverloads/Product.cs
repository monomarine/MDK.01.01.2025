using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.OperatorOverloads
{
    internal class Product
    {
        public string Name { get; set; }
        public int  Price { get; set; }

        public override string ToString()
        {
            return $"товар {Name}: стоимость за единицу {Price}";
        }

        public static bool operator > (Product left, Product right)
        {
            return left.Price > right.Price;
        }
        public static bool operator <(Product left, Product right)
        {
            return left.Price < right.Price;
        }

        public static int operator + (Product left, Product right)
        {
            return left.Price + right.Price;
        }
        public static int operator - (Product left, Product right)
        {
            return left.Price - right.Price;
        }
    }
}
