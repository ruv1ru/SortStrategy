using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SortStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var studentContext = new SortContext<Student>();
            studentContext.SetSortAlgorithm(new SelectionSort());

            studentContext.Add(new Student { Name = "Jack", Age = 25 });
            studentContext.Add(new Student { Name = "Kate", Age = 28 });
            studentContext.Add(new Student { Name = "Tim", Age = 22 });
            studentContext.Add(new Student { Name = "Dave", Age = 18 });

            DisplaySortedItems(studentContext.Sort(), studentContext.GetSortAlgorithmName());
            
            var accountContext = new SortContext<BankAccount>();
            accountContext.SetSortAlgorithm(new MergeSort());

            accountContext.Add(new BankAccount { AccountNo = "123-222-111", Balance = 25000 });
            accountContext.Add(new BankAccount { AccountNo = "123-222-222", Balance = 5000 });
            accountContext.Add(new BankAccount { AccountNo = "123-222-333", Balance = 15000 });
            accountContext.Add(new BankAccount { AccountNo = "123-222-444", Balance = 500000 });

            DisplaySortedItems(accountContext.Sort(), accountContext.GetSortAlgorithmName());

            var intContext = new SortContext<int>();
            intContext.SetSortAlgorithm(new BubbleSort());

            intContext.AddRange(new int[] {25, 25, 2, 33, 12, 5, 65, 24, 2, 10});

            DisplaySortedItems(intContext.Sort(), intContext.GetSortAlgorithmName());


            
            var doubleContext = new SortContext<double>();

            doubleContext.SetSortAlgorithm(new QuickSort());

            doubleContext.AddRange(new double[] {22.3, 2.5, 2.5, 33, 2, 5, 66.55, 2, 2, 9});

            DisplaySortedItems(doubleContext.Sort(), doubleContext.GetSortAlgorithmName());

            

            BenchmarkRunner.Run<BenchMarkSortTest>();

        }


        public static void DisplaySortedItems<T>(T[] sortedItems, string algorithmName)
        {

            Console.WriteLine($"Sorted with {algorithmName}");
            for(int i = 0; i < sortedItems.Length; i++)
            {
                Console.WriteLine(value: sortedItems[i].ToString());
            }
        }






    }

    public class BenchMarkSortTest
    {

        
        private int[] _testArray; 
        
        public BenchMarkSortTest()
        {
            _testArray = GetRandomArray();
        }


        [Benchmark]
        public void SortWithSelectionSort()
        {
            var context = new SortContext<int>();

            context.SetSortAlgorithm(new SelectionSort());

            context.AddRange(_testArray);

            context.Sort();
        }
        
        [Benchmark]
        public void SortWithMergeSort()
        {
            var context = new SortContext<int>();

            context.SetSortAlgorithm(new MergeSort());

            context.AddRange(_testArray);

            context.Sort();
        }
        
        [Benchmark]
        public void SortWithBubbleSort()
        {
            var context = new SortContext<int>();

            context.SetSortAlgorithm(new BubbleSort());

            context.AddRange(_testArray);

            context.Sort();
        }


        [Benchmark]
        public void SortWithQuickSort()
        {
            var context = new SortContext<int>();

            context.SetSortAlgorithm(new QuickSort());

            context.AddRange(_testArray);

            context.Sort();
        }

        
        private int[] GetRandomArray()
        {
            int[] test = new int[1000]; 

            Random randNum = new Random();
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = randNum.Next(1, 100);
            }
            return test;
        }
    }

    



    

}
