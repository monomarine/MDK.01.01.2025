using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    public class Product
    {
        private static int instances = 0;
        private int id;
        private string name;
        private float price;

        public int Id => id;
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }

        public Product(string name, float price)
        {
            id = ++instances;
            this.name = name;
            this.price = price;
        }

        public Product(int id, string name, float price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Id: {id} Название: {name} Цена: {price} Рублей";
        }
    }
}
