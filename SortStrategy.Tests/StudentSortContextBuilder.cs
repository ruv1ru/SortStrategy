using NUnit.Framework;
namespace SortStrategy.Tests
{
    public class StudentSortContextBuilder{
        public static StudentSortContextBuilder DefaultContext(){
            return new StudentSortContextBuilder();
        }

        private SortContext<Student> _studentContext;

        public StudentSortContextBuilder()
        {
            _studentContext = new SortContext<Student>();

            _studentContext.Add(new Student { Name = "Jack", Age = 25 });
            _studentContext.Add(new Student { Name = "Kate", Age = 28 });
            _studentContext.Add(new Student { Name = "Tim", Age = 22 });
            _studentContext.Add(new Student { Name = "Dave", Age = 18 });
            _studentContext.Add(new Student { Name = "John", Age = 20 });
            _studentContext.Add(new Student { Name = "Jim", Age = 18 });
            _studentContext.Add(new Student { Name = "Allan", Age = 23 });
            _studentContext.Add(new Student { Name = "Mark", Age = 24 });
            
        }
        
        public SortContext<Student> Build(){
            return _studentContext;
        }

        public StudentSortContextBuilder WithSelectionSort(){

            _studentContext.SetSortAlgorithm(new SelectionSort());
            return this;
        }

        public StudentSortContextBuilder WithMergeSort(){

            _studentContext.SetSortAlgorithm(new MergeSort());
            return this;
        }

        public StudentSortContextBuilder WithBubbleSortSort(){

            _studentContext.SetSortAlgorithm(new BubbleSort());
            return this;
        }

        public StudentSortContextBuilder WithQuickSort(){

            _studentContext.SetSortAlgorithm(new QuickSort());
            return this;
        }

        public static void AssertSortedResult(Student[] sortedStudents){

            Assert.AreEqual(sortedStudents.Length, 8);
            Assert.AreEqual(sortedStudents[0].Age, 18);
            Assert.AreEqual(sortedStudents[1].Age, 18);
            Assert.AreEqual(sortedStudents[2].Name, "John");
            Assert.AreEqual(sortedStudents[7].Age, 28);
        }

    }
}