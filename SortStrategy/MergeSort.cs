using System;

namespace SortStrategy
{
    public class MergeSort : ISortAlgorithm
    {
        
        
        public T[] Sort<T>(T[] sourceArray) where T: IComparable<T>
        {
            var sortedArray = (T[])sourceArray.Clone();

            var temp = new T[sortedArray.Length];

            Merge<T>(sortedArray, temp, 0, sortedArray.Length - 1);

            return sortedArray;

        }




        public static void Merge<T>(T[] array, T[] temp, int left, int right) where T: IComparable<T>
        {
            if(left >= right) return;

            int middle = (left + right) / 2;

            Merge(array, temp, left, middle);
            Merge(array, temp, middle + 1, right);

            Merge(array, temp, left, middle, right);

        }

        public static void Merge<T>(T[] array, T[] temp, int start, int middle, int end) where T: IComparable<T>
        {
            var leftIndex = start;
            var rightIndex = middle + 1;

            var i = start;

            while (leftIndex <= middle && rightIndex <= end)
            {
                //if(array[leftIndex] < array[rightIndex])
                if(array[leftIndex].CompareTo(array[rightIndex]) == -1)
                {
                    temp[i] = array[leftIndex];
                    leftIndex++;
                }
                else
                {
                    temp[i] = array[rightIndex];
                    rightIndex++;
                }
                i++;
            }

            // Copy remaining left half to temp array
            while(leftIndex <= middle)
            {
                temp[i] = array[leftIndex];
                leftIndex++;
                i++;
            }

            // Copy remaining right half to temp array
            while(rightIndex <= end)
            {
                temp[i] = array[rightIndex];
                rightIndex++;
                i++;
            }
            
            // Copy sorted temp array elements back to array
            i = start;

            while(i <= end)
            {
                array[i] = temp[i];
                i++;
            }
        }


        public string GetName()
        {
            return "Merge Sort";
        }
    }
}
