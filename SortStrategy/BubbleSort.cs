using System;

namespace SortStrategy
{
    public class BubbleSort : ISortAlgorithm
    {

        public T[] Sort<T>(T[] sourceArray) where T: IComparable<T>
        {
            var array = (T[])sourceArray.Clone();

            var lastIndex = array.Length - 1;

            var swapped = true;


            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < lastIndex; i++)
                {
                    //if (array[i] > array[i + 1])
                    if (array[i].CompareTo(array[i + 1]) == 1)
                    {
                        array.Swap(i, i + 1);
                        swapped = true;
                    }
                }

                lastIndex--;
            }


            return array;



        }

        public string GetName()
        {
            return "Bubble Sort";
        }
        



    }
}
