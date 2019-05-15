# SortStrategy
Strategy pattern applied to generic sorting algorithms.



    //Benchmark results for random integer array with 500 items
    |                Method |      Mean |      Error |     StdDev |
    |---------------------- |----------:|-----------:|-----------:|
    | SortWithSelectionSort | 220.52 us |  2.8713 us |  2.6859 us |
    |     SortWithMergeSort |  31.43 us |  0.6092 us |  0.5983 us |
    |    SortWithBubbleSort | 545.70 us | 10.8125 us | 10.1140 us |
    |     SortWithQuickSort | 954.28 us | 14.1800 us | 13.2639 us |

    //Benchmark results for random integer array with 1000 items
    |                Method |        Mean |     Error |    StdDev |
    |---------------------- |------------:|----------:|----------:|
    | SortWithSelectionSort |   800.00 us | 15.083 us | 14.108 us |
    |     SortWithMergeSort |    73.06 us |  1.231 us |  1.092 us |
    |    SortWithBubbleSort | 1,983.05 us | 34.103 us | 31.900 us |
    |     SortWithQuickSort | 1,901.96 us | 27.131 us | 25.378 us |
     
