using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Search
{
    internal static class Search
    {
        public static int LinearSearch(int key, params int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if(values[i] == key)
                {
					Console.WriteLine("Количество шагов: " + i);
					return i;
				}	
            }
			Console.WriteLine("Количество шагов: " + values.Length);
			return -1;
        }

        public static int IterativeBinarySearch(int key, params int[] values)
        {
            int left = 0;
            int right = values.Length - 1;
            int index = 0;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (values[middle] == key)
                {
					Console.WriteLine("Количество шагов: " + index);
					return middle;
				}
                else if (values[middle] > key)
                    right = middle - 1;
                else 
                    left = middle + 1;
                index++;
            }
			Console.WriteLine("Количество шагов: " + index);
			return -1;
        }

        private static int RecursiveBinarySearch(int key, int left, int right, int index, params int[] values)
        {
            index++;
            if (left >= right)
                return -1;
            int middle = left + (right - left) / 2;
            if (values[middle] == key)
            {
				Console.WriteLine("Количество шагов: " + index);
				return middle;
            }
            else if (values[middle] > key)
                return RecursiveBinarySearch(key, left, middle - 1, index, values);
            else
                return RecursiveBinarySearch(key, middle + 1, right, index, values);
        }

        public static int RecursiveBinarySearch(int key, params int[] values) => RecursiveBinarySearch(key, 0, values.Length, 0, values);

        public static int InterpolateSearch(int key, params int[] values)
        {
            if (values.Length == 0 || values == null)
                return -1;

            int left = 0;
            int right = values.Length - 1;
            int index = 0;
            while (left <= right && key >= values[left] && key <= values[right])
            {
                if (left == right)
                {
                    if (values[left] == key)
                    {
						Console.WriteLine("Количество шагов: " + index);
						return left;
					}    
 
                    return -1;
                }
                int pos = left + (key - values[left]) * (right - left) / 
                    (values[right] - values[left]);

                pos = Math.Clamp(pos, left, right);
                if (values[pos] == key)
                {
					Console.WriteLine("Количество шагов: " + index);
					return pos;
				}           
                else if (values[pos] < key)
                    left = pos + 1;
                else
                    right = pos - 1;
                index++;
            }
            return -1;
        }
    }
}
