using VisualizationUI.Sorting;
namespace InsertionSort.Tests
{
    [TestClass]
    public class InsertionSortFormTests
    {
        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            var insertionSortForm = new InsertionSortForm();

            insertionSortForm.SortModel.Data = insertionSortForm.GenerateRandomNumbers(100, insertionSortForm.givenNumberPanel.Height);

            Assert.IsNotNull(insertionSortForm.SortModel.Data);
            Assert.AreEqual(100, insertionSortForm.SortModel.Data.Length);
            Assert.IsTrue(insertionSortForm.SortModel.Data.All(num => num >=0 && num <= insertionSortForm.givenNumberPanel.Height));
        }

        [TestMethod]

        public void TestInsertionSortStep()
        {
            InsertionSortForm insertionSortForm = new InsertionSortForm();
            insertionSortForm.SortModel.Data = new int[] { 3, 1, 4, 1, 5, 9, 1, 1, 1, 1, 3, 9, 4 };

            bool result = insertionSortForm.InsertionSortStep();

            Assert.IsTrue(result);
        }
        public void TestBubbleSortReverseSorted()
        {
            // Arrange
            InsertionSortForm insertionSortForm = new InsertionSortForm();
            insertionSortForm.SortModel.Data = new int[] { 9, 7, 5, 3, 1 };

            // Act
            bool result = insertionSortForm.InsertionSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }
    }
}