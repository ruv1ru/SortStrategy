using System;
using System.Collections.Generic;

namespace SortStrategy
{
    public class SortContext<T> where T: IComparable<T>
    {
        private List<T> _items = new List<T>();
        private ISortAlgorithm _sortAlgorithm;

        public SortContext()
        {
            
        }

        public void SetSortAlgorithm(ISortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void AddRange(IEnumerable<T> items)
        {
            _items.AddRange(items);
        }

        public T[] Sort()
        {
            return _sortAlgorithm.Sort<T>(_items.ToArray());
        }
        public string GetSortAlgorithmName()
        {
            return _sortAlgorithm.GetName();
        }

    }
}
