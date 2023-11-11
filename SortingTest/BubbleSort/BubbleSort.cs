using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualizationUI.Sorting; // Assuming BubbleSortForm is in this namespace
using System.Linq;

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
            bubbleSortForm.GenerateRandomNumbers(bubbleSortForm.SortModel.Data, bubbleSortForm.givenNumberPanel.Height);

            // Assert
            Assert.IsNotNull(bubbleSortForm.SortModel.Data);
            Assert.AreEqual(100, bubbleSortForm.SortModel.Data.Length);
        }

        [TestMethod]
        public void TestBubbleSortStep()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.SortModel.Data = new int[] { 3, 2, 1 };

            // Act
            bubbleSortForm.SortStep(null, null); // Pass null arguments since they are not used in the method

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, bubbleSortForm.SortModel.Data);
        }

        [TestMethod]
        public void TestBubbleSortReverseSorted()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.SortModel.Data = new int[] { 3, 2, 1 }; // Reverse sorted array

            // Act
            bubbleSortForm?.SortStep(this, EventArgs.Empty);

            // Assert
            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, bubbleSortForm?.SortModel.Data);
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
    }
}
