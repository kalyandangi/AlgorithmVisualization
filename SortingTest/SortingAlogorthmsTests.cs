using VisualizationLibrary.Models;
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
            CommonInitialization(mergeSortForm, new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 });
            int middle = mergeSortForm.sortModel.Data.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[mergeSortForm.sortModel.Data.Length - middle];

            // Act
            bool result = mergeSortForm.MergeSortStep(mergeSortForm.sortModel.Data, leftArray, 0, rightArray);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]

        public void TestMergeSortReverseSorted()
        {
            // Arrange
            CommonInitialization(mergeSortForm, new int[] { 9, 7, 5, 3, 1 });
            int middle = mergeSortForm.sortModel.Data.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[mergeSortForm.sortModel.Data.Length - middle];

            // Act
            bool result = mergeSortForm.MergeSortStep(mergeSortForm.sortModel.Data, leftArray, 0, rightArray);
            
            // Assert
            Assert.IsTrue(result); 
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

    [TestClass]
    public class HeapSortFormTests
    {
        private HeapSortForm? heapSortForm;

        [TestInitialize]
        public void TestInitialize()
        {
            heapSortForm = new HeapSortForm();
        }

        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            TestGenerateRandomNumbers(heapSortForm, 100);
        }

        [TestMethod]
        public void TestHeapSortStep()
        {
            // Arrange
            CommonInitialization(heapSortForm, new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 });

            // Act
            bool result = heapSortForm.HeapSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting at least one swap
        }

        [TestMethod]
        public void TestHeapSortReverseSorted()
        {
            // Arrange
            CommonInitialization(heapSortForm, new int[] { 9, 7, 5, 3, 1 });

            // Act
            bool result = heapSortForm.HeapSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }

        [TestMethod]
        public void TestHeapSortEmptyArray()
        {
            // Arrange
            CommonInitialization(heapSortForm, new int[] { }); // Empty array

            // Act
            heapSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(heapSortForm.sortModel.Data);
            Assert.AreEqual(0, heapSortForm.sortModel.Data.Length);
        }

        [TestMethod]
        public void TestHeapSortAlreadySorted()
        {
            // Arrange
            CommonInitialization(heapSortForm, new int[] { 1, 2, 3 }); // Already sorted array

            // Act
            heapSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, heapSortForm.sortModel.Data);
        }

        private void CommonInitialization(HeapSortForm sortForm, int[] testData)
        {
            sortForm.sortModel.Data = testData;
        }

        private void TestGenerateRandomNumbers(HeapSortForm sortForm, int count)
        {
            sortForm.sortModel.Data = sortForm.GenerateRandomNumbers(count, sortForm.givenNumberPanel.Height);

            Assert.IsNotNull(sortForm.sortModel.Data);
            Assert.AreEqual(count, sortForm.sortModel.Data.Length);
            Assert.IsTrue(sortForm.sortModel.Data.All(num => num >= 0 && num <= sortForm.givenNumberPanel.Height));
        }
    }

    [TestClass]
    public class RadixSortFormTests
    {
        private RadixSortForm? radixSortForm;

        [TestInitialize]
        public void TestInitialize()
        {
            radixSortForm = new RadixSortForm();
        }

        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            TestGenerateRandomNumbers(radixSortForm, 100);
        }

        [TestMethod]
        public void TestRadixSortStep()
        {
            // Arrange
            CommonInitialization(radixSortForm, new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 });

            // Act
            bool result = radixSortForm.RadixSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting at least one swap
        }

        [TestMethod]
        public void TestRadixSortReverseSorted()
        {
            // Arrange
            CommonInitialization(radixSortForm, new int[] { 9, 7, 5, 3, 1 });

            // Act
            bool result = radixSortForm.RadixSortStep();

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }

        [TestMethod]
        public void TestRadixSortEmptyArray()
        {
            // Arrange
            CommonInitialization(radixSortForm, new int[] { }); // Empty array

            // Act
            radixSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(radixSortForm.sortModel.Data);
            Assert.AreEqual(0, radixSortForm.sortModel.Data.Length);
        }

        [TestMethod]
        public void TestHeapSortAlreadySorted()
        {
            // Arrange
            CommonInitialization(radixSortForm, new int[] { 1, 2, 3 }); // Already sorted array

            // Act
            radixSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, radixSortForm.sortModel.Data);
        }

        private void CommonInitialization(RadixSortForm sortForm, int[] testData)
        {
            sortForm.sortModel.Data = testData;
        }

        private void TestGenerateRandomNumbers(RadixSortForm sortForm, int count)
        {
            sortForm.sortModel.Data = sortForm.GenerateRandomNumbers(count, sortForm.givenNumberPanel.Height);

            Assert.IsNotNull(sortForm.sortModel.Data);
            Assert.AreEqual(count, sortForm.sortModel.Data.Length);
            Assert.IsTrue(sortForm.sortModel.Data.All(num => num >= 0 && num <= sortForm.givenNumberPanel.Height));
        }
    }

    [TestClass]
    public class QuickSortFormTests
    {
        private QuickSortForm? quickSortForm;

        [TestInitialize]
        public void TestInitialize()
        {
            quickSortForm = new QuickSortForm();
        }

        [TestMethod]
        public void TestGenerateRandomNumbers()
        {
            // Arrange
            TestGenerateRandomNumbers(quickSortForm, 100);
        }

        [TestMethod]
        public void TestQuickSortStep()
        {
            // Arrange
            CommonInitialization(quickSortForm, new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 });

            // Act
            bool result = quickSortForm.QuickSortStep(0, quickSortForm.sortModel.Data.Length - 1);

            // Assert
            Assert.IsTrue(result); // Expecting at least one swap
        }

        [TestMethod]
        public void TestQuickSortReverseSorted()
        {
            // Arrange
            CommonInitialization(quickSortForm, new int[] { 9, 7, 5, 3, 1 });

            // Act
            bool result = quickSortForm.QuickSortStep(0, quickSortForm.sortModel.Data.Length - 1);

            // Assert
            Assert.IsTrue(result); // Expecting no swap for a reverse-sorted array
        }

        [TestMethod]
        public void TestQuickSortEmptyArray()
        {
            // Arrange
            CommonInitialization(quickSortForm, new int[] { }); // Empty array

            // Act
            quickSortForm.StartSorting();

            // Assert
            Assert.IsNotNull(quickSortForm.sortModel.Data);
            Assert.AreEqual(0, quickSortForm.sortModel.Data.Length);
        }

        [TestMethod]
        public void TestQuickSortAlreadySorted()
        {
            // Arrange
            CommonInitialization(quickSortForm, new int[] { 1, 2, 3 }); // Already sorted array

            // Act
            quickSortForm.StartSorting();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, quickSortForm.sortModel.Data);
        }

        private void CommonInitialization(QuickSortForm sortForm, int[] testData)
        {
            sortForm.sortModel.Data = testData;
        }

        private void TestGenerateRandomNumbers(QuickSortForm sortForm, int count)
        {
            sortForm.sortModel.Data = sortForm.GenerateRandomNumbers(count, sortForm.givenNumberPanel.Height);

            Assert.IsNotNull(sortForm.sortModel.Data);
            Assert.AreEqual(count, sortForm.sortModel.Data.Length);
            Assert.IsTrue(sortForm.sortModel.Data.All(num => num >= 0 && num <= sortForm.givenNumberPanel.Height));
        }
    }
}
