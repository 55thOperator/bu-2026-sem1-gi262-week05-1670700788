using NUnit.Framework;

namespace Assignment
{
    public class Assignment_Testcase
    {
        private IAssignment assignment;

        [SetUp]
        public void Setup()
        {
            assignment = new StudentSolution();
        }

        [TestCase(new int[] { 5, 2, 8, 1, 9 }, new int[] { 1, 2, 5, 8, 9 }, TestName = "LCT01_SelectionSortAscending_BasicScenario")]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, TestName = "LCT01_SelectionSortAscending_AlreadySorted")]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 }, TestName = "LCT01_SelectionSortAscending_ReverseSorted")]
        [TestCase(new int[] { 42 }, new int[] { 42 }, TestName = "LCT01_SelectionSortAscending_SingleElement")]
        public void Test_LCT01_SelectionSortAscending(int[] numbers, int[] expected)
        {
            AssertSortedWithoutMutation(numbers, expected, assignment.LCT01_SelectionSortAscending);
        }

        [TestCase(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 11, 12, 22, 25, 34, 64, 90 }, TestName = "LCT02_BubbleSortAscending_BasicScenario")]
        [TestCase(new int[] { 3, 1, 3, 2, 1 }, new int[] { 1, 1, 2, 3, 3 }, TestName = "LCT02_BubbleSortAscending_WithDuplicates")]
        public void Test_LCT02_BubbleSortAscending(int[] numbers, int[] expected)
        {
            AssertSortedWithoutMutation(numbers, expected, assignment.LCT02_BubbleSortAscending);
        }

        [TestCase(new int[] { 12, 11, 13, 5, 6 }, new int[] { 5, 6, 11, 12, 13 }, TestName = "LCT03_InsertionSortAscending_BasicScenario")]
        [TestCase(new int[] { -5, 2, -3, 8, 0 }, new int[] { -5, -3, 0, 2, 8 }, TestName = "LCT03_InsertionSortAscending_WithNegatives")]
        public void Test_LCT03_InsertionSortAscending(int[] numbers, int[] expected)
        {
            AssertSortedWithoutMutation(numbers, expected, assignment.LCT03_InsertionSortAscending);
        }

        [TestCase(new int[] { 5, 2, 8, 1, 9 }, new int[] { 9, 8, 5, 2, 1 }, TestName = "AS01_SelectionSortDescending_BasicScenario")]
        [TestCase(new int[] { 7, 3, 7, 1, 3 }, new int[] { 7, 7, 3, 3, 1 }, TestName = "AS01_SelectionSortDescending_WithDuplicates")]
        public void Test_AS01_SelectionSortDescending(int[] numbers, int[] expected)
        {
            AssertSortedWithoutMutation(numbers, expected, assignment.AS01_SelectionSortDescending);
        }

        [TestCase(new int[] { 64, 34, 25, 12, 22, 11, 90 }, new int[] { 90, 64, 34, 25, 22, 12, 11 }, TestName = "AS02_BubbleSortDescending_BasicScenario")]
        [TestCase(new int[] { 9, 7, 5, 3, 1 }, new int[] { 9, 7, 5, 3, 1 }, TestName = "AS02_BubbleSortDescending_AlreadyDescending")]
        public void Test_AS02_BubbleSortDescending(int[] numbers, int[] expected)
        {
            AssertSortedWithoutMutation(numbers, expected, assignment.AS02_BubbleSortDescending);
        }

        [TestCase(new int[] { 12, 11, 13, 5, 6 }, new int[] { 13, 12, 11, 6, 5 }, TestName = "AS03_InsertionSortDescending_BasicScenario")]
        [TestCase(new int[] { -5, 2, -3, 8, 0 }, new int[] { 8, 2, 0, -3, -5 }, TestName = "AS03_InsertionSortDescending_WithNegatives")]
        public void Test_AS03_InsertionSortDescending(int[] numbers, int[] expected)
        {
            AssertSortedWithoutMutation(numbers, expected, assignment.AS03_InsertionSortDescending);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, TestName = "AS04_FindTheSecondLargestNumber_BasicScenario")]
        [TestCase(new int[] { 5, 5, 4, 3, 2 }, 4, TestName = "AS04_FindTheSecondLargestNumber_WithDuplicates")]
        [TestCase(new int[] { 3, 7, 1, 9, 5 }, 7, TestName = "AS04_FindTheSecondLargestNumber_UnorderedArray")]
        [TestCase(new int[] { -1, -5, 3, 0, 2 }, 2, TestName = "AS04_FindTheSecondLargestNumber_WithNegatives")]
        [TestCase(new int[] { 10, 5 }, 5, TestName = "AS04_FindTheSecondLargestNumber_TwoElements")]
        public void Test_AS04_FindTheSecondLargestNumber(int[] numbers, int expected)
        {
            Assert.AreEqual(expected, assignment.AS04_FindTheSecondLargestNumber(numbers));
        }

        [TestCase(new int[] { 1, 9, 3, 10, 4, 20, 2 }, 4, TestName = "EX01_FindLongestConsecutiveSequence_BasicScenario")]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, 5, TestName = "EX01_FindLongestConsecutiveSequence_AllConsecutive")]
        [TestCase(new int[] { 1, 3, 5, 7, 9 }, 1, TestName = "EX01_FindLongestConsecutiveSequence_NoConsecutive")]
        [TestCase(new int[] { 1, 2, 2, 3, 4 }, 4, TestName = "EX01_FindLongestConsecutiveSequence_WithDuplicates")]
        [TestCase(new int[] { 42 }, 1, TestName = "EX01_FindLongestConsecutiveSequence_SingleElement")]
        [TestCase(new int[] { 100, 4, 200, 1, 3, 2, 101, 102 }, 4, TestName = "EX01_FindLongestConsecutiveSequence_MultipleSequences")]
        [TestCase(new int[] { -2, -1, 0, 1, 2, 5 }, 5, TestName = "EX01_FindLongestConsecutiveSequence_WithNegatives")]
        public void Test_EX01_FindLongestConsecutiveSequence(int[] numbers, int expected)
        {
            Assert.AreEqual(expected, assignment.EX01_FindLongestConsecutiveSequence(numbers));
        }

        private static void AssertSortedWithoutMutation(
            int[] numbers,
            int[] expected,
            System.Func<int[], int[]> sort)
        {
            int[] original = (int[])numbers.Clone();
            int[] actual = sort(numbers);

            CollectionAssert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(original, numbers);
        }
    }
}
