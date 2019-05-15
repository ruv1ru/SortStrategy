using System;

namespace SortStrategy
{

    public class SelectionSort : ISortAlgorithm
    {

        public T[] Sort<T>(T[] sourceArray) where T: IComparable<T>
        {
            var sortedArray = (T[])sourceArray.Clone();

            var currentIndex = 0;

            while (currentIndex < sortedArray.Length)
            {
                var lowestValueIndex = currentIndex;
                var lowestValue = sortedArray[currentIndex];

                for (int i = currentIndex + 1; i < sortedArray.Length; i++)
                {
                    //if (sortedArray[i] < lowestValue)
                    if (sortedArray[i].CompareTo(lowestValue) == -1)
                    {
                        lowestValueIndex = i;
                        lowestValue = sortedArray[i];
                    }
                }

                if (lowestValueIndex != currentIndex)
                {
                    sortedArray.Swap(currentIndex, lowestValueIndex);
                }

                currentIndex++;
            }

            return sortedArray;



        }

        public string GetName()
        {
            return "Selection Sort";
        }
        



    }
}
