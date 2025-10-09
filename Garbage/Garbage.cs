using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage
{
    internal class Garbage
    {
        public string Name { get; set; }
        public List<int> Numbers { get; set; }
        public Dictionary<string, object> Data { get; set; }
        public byte[] Buffer { get; set; }

        public Garbage()
        {
            Name = "Пример";
            Numbers = new List<int> { 1, 2, 3 };
            Data = new Dictionary<string, object>
            {
                ["key1"] = "пример",
                ["key2"] = 12345679
            };
            Buffer = new byte[1024];
        }

        public Garbage(string name, int listSize, int bufferSize)
        {
            Name = name;
            Numbers = Enumerable.Range(1, listSize).ToList();
            Data = new Dictionary<string, object>();
            Buffer = new byte[bufferSize];

            for (int i = 0; i < bufferSize; i++)
            {
                Buffer[i] = (byte)(i % 256);
            }
        }
    }
}
