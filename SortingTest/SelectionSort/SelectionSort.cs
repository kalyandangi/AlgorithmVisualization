using VisualizationUI;
using VisualizationLibrary;
using VisualizationLibrary.Models;

namespace SelectionSort
{
    [TestClass]
    public class SelectionSortTests
    {
        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            var selectionSortForm = new SelectionSortForm();

            // Act
            selectionSortForm.GenerateRandomNumbers(100, selectionSortForm.givenNumberPanel.Height);

            // Assert
            Assert.IsNotNull(selectionSortForm.SortModel.Data);
            Assert.AreEqual(100, selectionSortForm.SortModel.Data.Length);
        }

        [TestMethod]
        public void TestSelectionSortStep()
        {
            // Arrange
            var selectionSortForm = new SelectionSortForm();
            selectionSortForm.SortModel.Data = new int[] { 3, 2, 1 };

            // Act
            while (selectionSortForm.SelectionSortStep())
            {
            }

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, selectionSortForm.SortModel.Data);
        }

        [TestMethod]
        public void TestSelectionSortReverseSorted()
        {
            // Arrange
            var selectionSortForm = new SelectionSortForm();
            selectionSortForm.SortModel.Data = new int[] { 3, 2, 1 }; // Reverse sorted array

            // Act
            var swapped = selectionSortForm.SelectionSortStep();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, selectionSortForm.SortModel.Data); // One step should sort the array
            Assert.IsTrue(swapped); // Swaps should occur in a reverse sorted array
        }
    }
}
