using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortEmp
{
    public class Quicksorter 
    {
        private static Random random = new Random();

        public static void QuickSort<T>(List<T> a)
                             where T : IComparable<T>
        {
            QuickSort<T>(a, 0, a.Count - 1);
        }

        public static void QuickSort<T>(List<T> items, IComparer<T> comparer)
        {
            QuickSort<T>(items, 0, items.Count - 1, comparer);
        }

        private static void QuickSort<T>(List<T> items, int startIndex, int endIndex, IComparer<T> comparer)
        {
            if (startIndex >= endIndex)
                return;

            int pivotIndex = ChoosePivotIndex(items, startIndex, endIndex);
            T pivot = items[pivotIndex];

            // swap pivot and first element
            Swap(items, startIndex, pivotIndex);

            int partitionIndex = startIndex + 1;
            for (int frontierIndex = partitionIndex; frontierIndex <= endIndex; frontierIndex++)
            {
                if (comparer.Compare(items[frontierIndex], pivot) < 0)
                {
                    Swap(items, frontierIndex, partitionIndex);
                    partitionIndex++;
                }
            }

            // put pivot back
            items[startIndex] = items[partitionIndex - 1];
            items[partitionIndex - 1] = pivot;

            // recursively sort left half
            QuickSort(items, startIndex, partitionIndex - 2, comparer);
            // recursively sort right half
            QuickSort(items, partitionIndex, endIndex, comparer);
        }

        public static void QuickSort<T>(List<T> items, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (startIndex >= endIndex)
                return;

            int pivotIndex = ChoosePivotIndex(items, startIndex, endIndex);
            T pivot = items[pivotIndex];

            // swap pivot and first element
            Swap(items, startIndex, pivotIndex);

            int partitionIndex = startIndex + 1;
            for (int frontierIndex = partitionIndex; frontierIndex <= endIndex; frontierIndex++)
            {
                if (items[frontierIndex].CompareTo(pivot) < 0)
                {
                    Swap(items, frontierIndex, partitionIndex);
                    partitionIndex++;
                }
            }

            // put pivot back
            items[startIndex] = items[partitionIndex - 1];
            items[partitionIndex - 1] = pivot;

            // recursively sort left half
            QuickSort(items, startIndex, partitionIndex - 2);
            // recursively sort right half
            QuickSort(items, partitionIndex, endIndex);
        }


        protected static int ChoosePivotIndex<T>(List<T> items, int startIndex, int endIndex)
        {
            return random.Next(startIndex, endIndex);
        }

        private static void Swap<T>(IList<T> items, int aIndex, int bIndex)
        {
            T temp = items[aIndex];
            items[aIndex] = items[bIndex];
            items[bIndex] = temp;
        }
    }
}
