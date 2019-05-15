using System;

namespace SortStrategy
{
    public class QuickSort : ISortAlgorithm
    {
        

        public T[] Sort<T>(T[] sourceArray) where T : IComparable<T>
        {
            var array = (T[])sourceArray.Clone();

            QSort(array, 0, array.Length -1);

            return array;

        }


        public static void QSort<T>(T[] array, int startIndex, int endIndex) where T: IComparable<T>
        {
            if(endIndex <= startIndex) return;

            int pivot = new Random().Next(startIndex, endIndex);

            var leftIndex = startIndex;
            var rightIndex = endIndex;

            var pivotValue = array[pivot];

            while(leftIndex < rightIndex)
            {
                //while(array[leftIndex] < pivotValue)
                while(array[leftIndex].CompareTo(pivotValue) == -1)
                {
                    leftIndex++;
                }
                
                //while (array[rightIndex] > pivotValue)
                while (array[rightIndex].CompareTo(pivotValue) == 1)
                {
                    rightIndex--;
                }

                if (leftIndex <= rightIndex)
                {
                    array.Swap(leftIndex,rightIndex);
                    leftIndex++;
                    rightIndex--;
                }
            }

            QSort(array, startIndex, leftIndex -1);
            QSort(array, leftIndex, endIndex);


        }

        public string GetName()
        {
            return "Quick Sort";
        }

    }
}
