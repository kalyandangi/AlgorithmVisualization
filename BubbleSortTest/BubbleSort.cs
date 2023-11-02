
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
            bubbleSortForm.GenerateRandomNumbers();

            //Assert
            Assert.IsNotNull(bubbleSortForm.data);
            Assert.AreEqual(bubbleSortForm.data.Length, bubbleSortForm.givenNumberPanel.Width);

        }

        [TestMethod]

        public void TestBubbleSortStep()
        {
            // Arrange
            var bubbleSortForm = new BubbleSortForm();
            bubbleSortForm.data = new int[] { 3, 2, 1 };

            // Act
            var swapped = bubbleSortForm.BubbleSortStep();

            // Assert
            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, bubbleSortForm.data);
            Assert.IsTrue(swapped);
        }

    }
    
}