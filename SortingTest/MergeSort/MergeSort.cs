using VisualizationUI.Sorting;

namespace MergeSort
{
    [TestClass]
    public class MergeSortFormTests
    {
        [TestMethod]
        public void TestMergeSortStep() 
        { 

            // Arrange
            MergeSortForm mergeSortForm  = new MergeSortForm();
            mergeSortForm.SortModel.Data = new int[] { 1, 2, 3, 3, 1, 4, 1, 2, 3, 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 1, 5, 9, 2, 6, 5, 3 };

            // Act
            mergeSortForm.MergeSortStep(mergeSortForm.SortModel.Data, new int[mergeSortForm.SortModel.Data.Length / 2], new int[mergeSortForm.SortModel.Data.Length / 2]);

            // Assert
            // Verify that the array is sorted after calling MergeSortStep
            Assert.IsTrue(mergeSortForm.IsSorted(mergeSortForm.SortModel.Data));
        }
        
        [TestMethod]
        public void TestMergeSortReverseSorted()
        {
            // Arrange
            MergeSortForm mergeSortForm = new MergeSortForm();
            mergeSortForm.SortModel.Data = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            // Act
            mergeSortForm.MergeSortStep(mergeSortForm.SortModel.Data, new int[mergeSortForm.SortModel.Data.Length / 2], new int[mergeSortForm.SortModel.Data.Length / 2]);

            // Assert
            // Verify that the array is sorted after calling MergeSortStep
            Assert.IsTrue(mergeSortForm.IsSorted(mergeSortForm.SortModel.Data));
        }

    }
}