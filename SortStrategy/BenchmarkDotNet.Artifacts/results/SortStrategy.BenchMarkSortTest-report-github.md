``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Sierra 10.12.6 (16G1815) [Darwin 16.7.0]
Intel Core i5-7360U CPU 2.30GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.106
  [Host]     : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.4 (CoreCLR 4.6.27521.02, CoreFX 4.6.27521.01), 64bit RyuJIT


```
|                Method |        Mean |     Error |    StdDev |
|---------------------- |------------:|----------:|----------:|
| SortWithSelectionSort |   800.00 us | 15.083 us | 14.108 us |
|     SortWithMergeSort |    73.06 us |  1.231 us |  1.092 us |
|    SortWithBubbleSort | 1,983.05 us | 34.103 us | 31.900 us |
|     SortWithQuickSort | 1,901.96 us | 27.131 us | 25.378 us |
