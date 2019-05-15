using System;

namespace SortStrategy
{
    public interface ISortAlgorithm
    {
        T[] Sort<T>(T[] sourceArray) where T: IComparable<T>;
        string GetName();
    }
}
