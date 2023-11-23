using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualizationUI;
using VisualizationUI.Sorting;

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class BubbleSortFormTests
    {
        private BubbleSortForm bubbleSortForm;

        [TestInitialize]
        public void TestInitialize()
        {
            bubbleSortForm = new BubbleSortForm();
        }

        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            TestGenerateRandomNumbers(bubbleSortForm, 100);
        }

        [TestMethod]
        public void TestBubbleSortStep()
        {
            // Arrange
            CommonInitialization(bubbleSortForm, new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 });

            // Act
            bool result = bubbleSortForm.BubbleSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting at least one swap
        }

        [TestMethod]
        public void TestBubbleSortReverseSorted()
        {
            // Arrange
            CommonInitialization(bubbleSortForm, new int[] { 9, 7, 5, 3, 1 });

            // Act
            bool result = bubbleSortForm.BubbleSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }

        [TestMethod]
        public void TestBubbleSortEmptyArray()
        {
            // Arrange
            CommonInitialization(bubbleSortForm, new int[] { }); // Empty array

            // Act
            bubbleSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(bubbleSortForm.sortModel.Data);
            Assert.AreEqual(0, bubbleSortForm.sortModel.Data.Length);
        }

        [TestMethod]
        public void TestBubbleSortAlreadySorted()
        {
            // Arrange
            CommonInitialization(bubbleSortForm, new int[] { 1, 2, 3 }); // Already sorted array

            // Act
            bubbleSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, bubbleSortForm.sortModel.Data);
        }

        private void CommonInitialization(BubbleSortForm sortForm, int[] testData)
        {
            sortForm.sortModel.Data = testData;
        }

        private void TestGenerateRandomNumbers(BubbleSortForm sortForm, int count)
        {
            sortForm.sortModel.Data = sortForm.GenerateRandomNumbers(count, sortForm.givenNumberPanel.Height);

            Assert.IsNotNull(sortForm.sortModel.Data);
            Assert.AreEqual(count, sortForm.sortModel.Data.Length);
            Assert.IsTrue(sortForm.sortModel.Data.All(num => num >= 0 && num <= sortForm.givenNumberPanel.Height));
        }
    }

    [TestClass]
    public class InsertionSortFormTests
    {
        private InsertionSortForm? insertionSortForm;

        [TestInitialize]
        public void TestInitialize()
        {
            insertionSortForm = new InsertionSortForm();
        }

        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            TestGenerateRandomNumbers(insertionSortForm, 100);
        }

        [TestMethod]
        public void TestInsertionSortStep()
        {
            // Arrange
            CommonInitialization(insertionSortForm, new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 });

            // Act
            bool result = insertionSortForm.InsertionSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting at least one swap
        }

        [TestMethod]
        public void TestInsertionSortReverseSorted()
        {
            // Arrange
            CommonInitialization(insertionSortForm, new int[] { 9, 7, 5, 3, 1 });

            // Act
            bool result = insertionSortForm.InsertionSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }

        [TestMethod]
        public void TestInsertionSortEmptyArray()
        {
            // Arrange
            CommonInitialization(insertionSortForm, new int[] { }); // Empty array

            // Act
            insertionSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(insertionSortForm.sortModel.Data);
            Assert.AreEqual(0, insertionSortForm.sortModel.Data.Length);
        }

        [TestMethod]
        public void TestInsertionSortAlreadySorted()
        {
            // Arrange
            CommonInitialization(insertionSortForm, new int[] { 1, 2, 3 }); // Already sorted array

            // Act
            insertionSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, insertionSortForm.sortModel.Data);
        }

        private void CommonInitialization(InsertionSortForm sortForm, int[] testData)
        {
            sortForm.sortModel.Data = testData;
        }

        private void TestGenerateRandomNumbers(InsertionSortForm sortForm, int count)
        {
            sortForm.sortModel.Data = sortForm.GenerateRandomNumbers(count, sortForm.givenNumberPanel.Height);

            Assert.IsNotNull(sortForm.sortModel.Data);
            Assert.AreEqual(count, sortForm.sortModel.Data.Length);
            Assert.IsTrue(sortForm.sortModel.Data.All(num => num >= 0 && num <= sortForm.givenNumberPanel.Height));
        }
    }

    [TestClass]
    public class SelectionSortFormTests
    {
        private SelectionSortForm? selectionSortForm;

        [TestInitialize]
        public void TestInitialize()
        {
            selectionSortForm = new SelectionSortForm();
        }

        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            TestGenerateRandomNumbers(selectionSortForm, 100);
        }

        [TestMethod]
        public void TestInsertionSortStep()
        {
            // Arrange
            CommonInitialization(selectionSortForm, new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 });

            // Act
            bool result = selectionSortForm.SelectionSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting at least one swap
        }

        [TestMethod]
        public void TestInsertionSortReverseSorted()
        {
            // Arrange
            CommonInitialization(selectionSortForm, new int[] { 9, 7, 5, 3, 1 });

            // Act
            bool result = selectionSortForm.SelectionSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }

        [TestMethod]
        public void TestInsertionSortEmptyArray()
        {
            // Arrange
            CommonInitialization(selectionSortForm, new int[] { }); // Empty array

            // Act
            selectionSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(selectionSortForm.sortModel.Data);
            Assert.AreEqual(0, selectionSortForm.sortModel.Data.Length);
        }

        [TestMethod]
        public void TestInsertionSortAlreadySorted()
        {
            // Arrange
            CommonInitialization(selectionSortForm, new int[] { 1, 2, 3 }); // Already sorted array

            // Act
            selectionSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, selectionSortForm.sortModel.Data);
        }

        private void CommonInitialization(SelectionSortForm sortForm, int[] testData)
        {
            sortForm.sortModel.Data = testData;
        }

        private void TestGenerateRandomNumbers(SelectionSortForm sortForm, int count)
        {
            sortForm.sortModel.Data = sortForm.GenerateRandomNumbers(count, sortForm.givenNumberPanel.Height);

            Assert.IsNotNull(sortForm.sortModel.Data);
            Assert.AreEqual(count, sortForm.sortModel.Data.Length);
            Assert.IsTrue(sortForm.sortModel.Data.All(num => num >= 0 && num <= sortForm.givenNumberPanel.Height));
        }
    }

    [TestClass]
    public class MergeSortFormTests
    {
        private MergeSortForm? mergeSortForm;

        [TestInitialize]
        public void TestInitialize()
        {
            mergeSortForm = new MergeSortForm();
        }

        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            TestGenerateRandomNumbers(mergeSortForm, 100);
        }

        [TestMethod]
        public void TestMergeSortStep()
        {
            // Arrange
            int[] testData = { 9, 7, 5, 3, 1 };
            mergeSortForm.sortModel.Data = testData;

            // Act
            mergeSortForm.SortStep(null, null);

            // Assert
            Assert.IsTrue(mergeSortForm.IsSorted(mergeSortForm.sortModel.Data));
        }
        [TestMethod]
        public void TestMergeSortReverseSorted()
        {
            // Arrange
            int[] testData = { 9, 7, 5, 3, 1 };
            mergeSortForm.sortModel.Data = testData;

            // Act
            mergeSortForm.SortStep(null, null);

            // Assert
            Assert.IsTrue(mergeSortForm.IsSorted(mergeSortForm.sortModel.Data));
        }

        [TestMethod]
        public void TestMergeSortEmptyArray()
        {
            // Arrange
            CommonInitialization(mergeSortForm, new int[] { }); // Empty array

            // Act
            mergeSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(mergeSortForm.sortModel.Data);
            Assert.AreEqual(0, mergeSortForm.sortModel.Data.Length);
        }

        [TestMethod]
        public void TestMergeSortAlreadySorted()
        {
            // Arrange
            CommonInitialization(mergeSortForm, new int[] { 1, 2, 3 }); // Already sorted array

            // Act
            mergeSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, mergeSortForm.sortModel.Data);
        }

        private void CommonInitialization(MergeSortForm sortForm, int[] testData)
        {
            sortForm.sortModel.Data = testData;
        }

        private void TestGenerateRandomNumbers(MergeSortForm sortForm, int count)
        {
            sortForm.sortModel.Data = sortForm.GenerateRandomNumbers(count, sortForm.givenNumberPanel.Height);

            Assert.IsNotNull(sortForm.sortModel.Data);
            Assert.AreEqual(count, sortForm.sortModel.Data.Length);
            Assert.IsTrue(sortForm.sortModel.Data.All(num => num >= 0 && num <= sortForm.givenNumberPanel.Height));
        }
    }
}
