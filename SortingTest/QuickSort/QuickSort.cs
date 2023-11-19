
using VisualizationUI.Sorting;
namespace QuickSort
{
    [TestClass]
    public class QuickSortFormTests
    {
        [TestMethod]
        public void TestQuickSortStep()
        {
            // Arrange
            QuickSortForm quickSortForm = new QuickSortForm();
            quickSortForm.SortModel.Data = new int[] { 1, 2, 3, 3, 1, 4, 1, 2, 3, 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 1, 5, 9, 2, 6, 5, 3 };

            // Act
            quickSortForm.QuickSortStep(0, quickSortForm.SortModel.Data.Length - 1);

            // Assert
            // Verify that the array is sorted after calling MergeSortStep
            Assert.IsTrue(quickSortForm.IsSorted(quickSortForm.SortModel.Data));

        }

        [TestMethod]
        public void TestQuickSortReverseSorted()
        {
            // Arrange
            QuickSortForm quickSortForm = new QuickSortForm();
            quickSortForm.SortModel.Data = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Act
            // quickSortForm.QuickSortStep(mergeSortForm.SortModel.Data, new int[mergeSortForm.SortModel.Data.Length / 2], new int[mergeSortForm.SortModel.Data.Length / 2]);
            quickSortForm.QuickSortStep(0, quickSortForm.SortModel.Data.Length - 1);
            // Assert
            // Verify that the array is sorted after calling MergeSortStep
            Assert.IsTrue(quickSortForm.IsSorted(quickSortForm.SortModel.Data));
        }

    }
}