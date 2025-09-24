using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    internal class Sort
    {
        public static int BubbleSort(ref int[] data)
        {
            int steps = 0;
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {

                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                        steps++;
                    }

                }
            }
            return steps;

        }

        public static int SelectionSort(ref int[] data)
        {
            int steps = 0;
            for (int i = 0; i < data.Length - 1; i++)
            {
                int minInd = i; //предполагаем что текущий элемент - минимальный
                for (int j = i + 1; j < data.Length; j++)
                {
                    //если в оставшемся диапазоне встречаем значение меньще текущего
                    if (data[j] < data[minInd])
                    {

                        minInd = j;//то значение индекса минимального значения меняем
                    }
                }
                //если нашли что то меньше текущего - то меняем значения местами
                if (minInd != i)
                {
                    steps++;
                    int temp = data[i];
                    data[i] = data[minInd];
                    data[minInd] = temp;

                }
            }
            return steps;
        }

        public static int InsertionSort(ref int[] data)
        {
            int steps = 0;
            for (int i = 1; i < data.Length; i++)
            {
                int key = data[i];
                int j = i - 1;

                while (j >= 0 && data[j] > key)
                {
                    data[j + 1] = data[j];
                    j--;
                }
                if (j >= 0) steps++;
                data[j + 1] = key;
            }
            return steps;
        }

        #region QuickSort
        public static int QuickSort(int[] data)
        {
            int steps = 0;
            QuickSortReqursive(data, 0, data.Length - 1, ref steps);
            return steps;
        }


        private static void QuickSortReqursive(int[] data, int start, int end, ref int steps)
        {
            if (start < end)
            {
                int pivot = GetPivotIndex(data, start, end, ref steps);
                QuickSortReqursive(data, start, pivot - 1, ref steps);
                QuickSortReqursive(data, pivot + 1, end, ref steps);
            }
        }

        private static int GetPivotIndex(int[] data, int start, int end, ref int steps)
        {
            int middle = start + (end - start) / 2;
            int pivotValue = data[middle];
            Swap(data, middle, end, ref steps); //временно опорную точку переместить в конец

            int i = start; //предполагаем что первый элемент больше опорного
            for (int j = start; j < end; j++)
            {
                if (data[j] <= pivotValue)
                {
                    Swap(data, i, j, ref steps);
                    i++;
                }
            }
            //перезаписываем опорную точку на нужную позицию
            Swap(data, i, end, ref steps);
            return i;
        }

        private static void Swap(int[] data, int pos1, int pos2, ref int steps)
        {
            int temp = data[pos1];
            data[pos1] = data[pos2];
            data[pos2] = temp;
            steps++;
        }
        #endregion

        #region MergeSort

        public static int MergeSort(int[] data)
        {
            if (data.Length == 0) return 0;
            int steps = 0;
            int[] temp = new int[data.Length];
            MergeSortRecursive(data, 0, data.Length - 1, temp, ref steps);
            return steps;
        }
        private static void MergeSortRecursive(int[] data, int start, int end, int[] temp, ref int steps)
        {
            if (start < end)
            {
                int middle = start + (end - start) / 2;

                MergeSortRecursive(data, start, middle, temp, ref steps);
                MergeSortRecursive(data, middle + 1, end, temp, ref steps);

                Merge(data, start, middle, end, temp, ref steps);
            }
        }

        private static void Merge(int[] data, int start, int middle, int end, int[] temp, ref int steps)
        {
            int i = start; //начало левого подмассива
            int j = middle + 1; //начало правого подпассива
            int k = start; //текущая позиция во временном подмассиве

            while (i <= middle && j <= end)
            {
                if (data[i] <= data[j])
                {
                    temp[k] = data[i];
                    steps++;
                    i++;
                }
                else
                {
                    temp[k] = data[j];
                    steps++;
                    j++;
                }
                k++;
            }
            while (i <= middle)
            {
                temp[k] = data[i];
                steps++;
                i++;
                k++;

            }
            while (j <= end)
            {
                temp[k] = data[j];
                steps++;
                j++;
                k++;
            }
            for (k = start; k <= end; k++)
            {
                data[k] = temp[k];
                steps++;
            }
        }

        #endregion

    }
}
