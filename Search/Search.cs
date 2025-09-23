using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal static class Search
    {
        public static int LinearSearch(int key, params int[] values)
        {
            int steps = 0;
            for (int i = 0; i < values.Length; i++)
            {
                steps++;
                if (values[i] == key)
                {
                    Console.WriteLine($"Линейный поиск нашел элемент за {steps} шагов");
                    return i;
                }
            }
            Console.WriteLine($"Линейный поиск не нашел элемент за {steps} шагов");
            return -1;
        }

        public static int IterativeBinarySearch(int key, params int[] values)
        {
            int steps = 0;
            int left = 0;
            int right = values.Length - 1;

            while (left <= right)
            {
                steps++;
                int middle = (left + right) / 2;

                if (values[middle] == key)
                {
                    Console.WriteLine($"Бинарный поиск нашел элемент за {steps} шагов");
                    return middle;
                }
                else if (values[middle] > key)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            Console.WriteLine($"Бинарный поиск не нашел элемент за {steps} шагов");
            return -1;
        }

        private static int RecursiveBinarySearch(int key, int left, int right, int steps, params int[] values)
        {
            if (left > right)
            {
                Console.WriteLine($"Рекурсивный поиск не нашел элемент за {steps} шагов");
                return -1;
            }

            steps++;
            int middle = left + (right - left) / 2;

            if (values[middle] == key)
            {
                Console.WriteLine($"Рекурсивный поиск нашел элемент за {steps} шагов");
                return middle;
            }
            else if (values[middle] > key)
                return RecursiveBinarySearch(key, left, middle - 1, steps, values);
            else
                return RecursiveBinarySearch(key, middle + 1, right, steps, values);
        }

        public static int RecursiveBinarySearch(int key, params int[] values)
        {
            return RecursiveBinarySearch(key, 0, values.Length - 1, 0, values);
        }

        public static int InterpolateSearch(int key, params int[] values)
        {
            int steps = 0;
            int left = 0;
            int right = values.Length - 1;

            while (left <= right && key >= values[left] && key <= values[right])
            {
                steps++;
                if (left == right)
                {
                    if (values[left] == key)
                    {
                        Console.WriteLine($"Интерполяционный поиск нашел элемент за {steps} шагов");
                        return left;
                    }
                    Console.WriteLine($"Интерполяционный поиск не нашел элемент за {steps} шагов");
                    return -1;
                }

                int pos = left + (key - values[left]) * (right - left) /
                         (values[right] - values[left]);

                pos = Math.Clamp(pos, left, right);

                if (values[pos] == key)
                {
                    Console.WriteLine($"Интерполяционный поиск нашел элемент за {steps} шагов");
                    return pos;
                }
                else if (values[pos] < key)
                    left = pos + 1;
                else
                    right = pos - 1;
            }
            Console.WriteLine($"Интерполяционный поиск не нашел элемент за {steps} шагов");
            return -1;
        }
    }
}
