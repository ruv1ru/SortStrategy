using System;

namespace SortStrategy
{
    public class Student: IComparable<Student>
    {   
        public string Name {get;set;}
        public int Age {get;set;}

        public int CompareTo(Student other)
        {
            if(this.Age == other.Age) return 0;
            if(this.Age < other.Age) return -1;
            return 1;

        }

        public override string ToString() => $"Student Name: {Name}, Age: {Age}";

    }
}
