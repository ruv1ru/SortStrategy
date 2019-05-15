using NUnit.Framework;

namespace SortStrategy.Tests
{
    public class SortStrategyTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SortStudentsWithSelectionSort_ShouldReturnStudentSotredByAge()
        {
            var studentContext = StudentSortContextBuilder.DefaultContext().WithSelectionSort().Build();

            var sortedStudents = studentContext.Sort();

            StudentSortContextBuilder.AssertSortedResult(sortedStudents);

        }

        [Test]
        public void SortStudentsWithMergeSort_ShouldReturnStudentSotredByAge()
        {
            var studentContext = StudentSortContextBuilder.DefaultContext().WithMergeSort().Build();

            var sortedStudents = studentContext.Sort();

            StudentSortContextBuilder.AssertSortedResult(sortedStudents);
        }

        [Test]
        public void SortStudentsWithBubbleSort_ShouldReturnStudentSotredByAge()
        {
            var studentContext = StudentSortContextBuilder.DefaultContext().WithBubbleSortSort().Build();

            var sortedStudents = studentContext.Sort();
            StudentSortContextBuilder.AssertSortedResult(sortedStudents);

        }



        [Test]
        public void SortStudentsWithQuickSort_ShouldReturnStudentSotredByAge()
        {
            var studentContext = StudentSortContextBuilder.DefaultContext().WithQuickSort().Build();

            var sortedStudents = studentContext.Sort();
            StudentSortContextBuilder.AssertSortedResult(sortedStudents);

        }
    }
}