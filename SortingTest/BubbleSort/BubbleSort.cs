using VisualizationUI.Sorting; // Assuming BubbleSortForm is in this namespace

namespace BubbleSort.Tests
{
    [TestClass]
    public class BubbleSortFormTests
    {
        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();

            // Act
            bubbleSortForm.SortModel.Data = bubbleSortForm.GenerateRandomNumbers(100, bubbleSortForm.givenNumberPanel.Height);

            // Assert
            Assert.IsNotNull(bubbleSortForm.SortModel.Data);
            Assert.AreEqual(100, bubbleSortForm.SortModel.Data.Length);
            Assert.IsTrue(bubbleSortForm.SortModel.Data.All(num => num >= 0 && num <= bubbleSortForm.givenNumberPanel.Height));
        }

        [TestMethod]
        public void TestBubbleSortStep()
        {
            // Arrange
            BubbleSortForm bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.SortModel.Data = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };

            // Act
            bool result = bubbleSortForm.BubbleSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting at least one swap
        }
        [TestMethod]
        public void TestBubbleSortReverseSorted()
        {
            // Arrange
            BubbleSortForm bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.SortModel.Data = new int[] { 9, 7, 5, 3, 1 };

            // Act
            bool result = bubbleSortForm.BubbleSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }

        [TestMethod]
        public void TestStartSorting()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();

            // Act
            bubbleSortForm.StartSorting();

            // Assert
            Assert.IsTrue(bubbleSortForm.isSorting);
            Assert.IsTrue(bubbleSortForm.sortingTimer.Enabled);
        }

        [TestMethod]
        public void TestStartSortingWhenSortingInProgress()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.SortModel.IsSortingInProgress = true;

            // Act
            bubbleSortForm.StartSorting();

            // Assert
            Assert.IsFalse(bubbleSortForm.isSorting);
            Assert.IsFalse(bubbleSortForm.sortingTimer.Enabled);
            // Add more assertions if necessary based on the expected behavior when sorting is already in progress
        }
        public void TestBubbleSortEmptyArray()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.SortModel.Data = new int[] { }; // Empty array

            // Act
            bubbleSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(bubbleSortForm.SortModel.Data);
            Assert.AreEqual(0, bubbleSortForm.SortModel.Data.Length);
        }

        [TestMethod]
        public void TestBubbleSortAlreadySorted()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.SortModel.Data = new int[] { 1, 2, 3 }; // Already sorted array

            // Act
            bubbleSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, bubbleSortForm.SortModel.Data);
        }
    }
}
