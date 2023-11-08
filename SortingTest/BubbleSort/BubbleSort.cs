
using VisualizationUI;
using VisualizationLibrary;
using VisualizationLibrary.Models;

namespace BubbleSort
{
    [TestClass]
    public class BubbleSortTests
    {
        
        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            //Arrange
            var bubbleSortForm = new BubbleSortForm();

            //Act
            bubbleSortForm.GenerateRandomNumbers(bubbleSortForm.givenNumberPanel.Width, bubbleSortForm.givenNumberPanel.Height);

            //Assert
            Assert.IsNotNull(bubbleSortForm.BubbleSortModel.Data);
            Assert.AreEqual(100, bubbleSortForm.BubbleSortModel.Data.Length);

        }

        [TestMethod]

        public void TestBubbleSortStep()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.BubbleSortModel.Data = new int[] { 3, 2, 1 }; //

            // Act
            while (bubbleSortForm.BubbleSortStep())//
            {

            }

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, bubbleSortForm.BubbleSortModel.Data);
        }
        [TestMethod]
        public void TestBubbleSortReverseSorted()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.BubbleSortModel.Data = new int[] { 3, 2, 1 }; // Reverse sorted array

            // Act
            var swapped = bubbleSortForm.BubbleSortStep();

            // Assert
            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, bubbleSortForm.BubbleSortModel.Data); // One step should reverse an array
            Assert.IsTrue(swapped); // Swaps should occur in a reverse sorted array
        }

    }
    
}