using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.SortVisualizer;
using VisualizationLibrary.Models;

namespace VisualizationUI.Sorting
{
    public partial class MergeSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        public SortModel sortModel { get; set; } = new SortModel();

        public MergeSortForm()
        {
            InitializeComponent();
            InitializeSortingTimer();

        }
        private void InitializeSortingTimer()
        {
            sortingTimer.Interval = 1;
            sortingTimer.Tick += Timer_Tick;
            sortingTimer.Enabled = false;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            SortStep(sender, e);
        }

        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.GenerateDrawData(data, graphics, panelWidth, panelHeight);
        }

        public void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.ResultDrawData(data, graphics, panelWidth, panelHeight);
        }
        public int[] GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            return visualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
        }

        public void DisplayGeneratedData(int[] data, System.Windows.Controls.RichTextBox richTextBox)
        {
            visualizerHelper.DisplayGeneratedData(data, richTextBox);
        }

        public void DisplaySortedData(int[] data, System.Windows.Controls.RichTextBox richTextBox)
        {
            visualizerHelper.DisplaySortedData(data, richTextBox);
        }

        public void StartSorting()
        {
            visualizerHelper.StartSorting(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height, SortStep);
        }
        public void SortStep(object sender, EventArgs e)
        {
            if (sortModel.Data.Length <= 1)
            {
                return;
            }
            int middle = sortModel.Data.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[sortModel.Data.Length - middle];

            Array.Copy(sortModel.Data, 0, leftArray, 0, middle);
            Array.Copy(sortModel.Data, middle, rightArray, 0, sortModel.Data.Length - middle);


            MergeSortStep(sortModel.Data, leftArray, 0, rightArray);

            ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);

            // Convert array to string and set it to WinForms RichTextBox
            sortRichTextBox.Text = string.Join(" ", sortModel.Data);

        }
        public bool MergeSortStep(int[] result, int[] leftArray, int v, int[] rightArray)
        {
            int i = 0, j = 0, k = 0;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    result[k++] = leftArray[i++];
                }
                else
                {
                    result[k++] = rightArray[j++];
                }
            }

            while (i < leftArray.Length)
            {
                result[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                result[k++] = rightArray[j++];
            }

            return true;
        }
        public bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }


        private void generateNumberButton_Click_1(object sender, EventArgs e)
        {
            int panelHeight = givenNumberPanel.Height;
            int panelWidth = givenNumberPanel.Width;
            sortModel.Data = GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData(sortModel.Data, givenNumberPanel.CreateGraphics(), givenNumberPanel.Width, givenNumberPanel.Height);
            // Convert array to string and set it to WinForms RichTextBox
            givenNumberRichTextBox.Text = string.Join(" ", sortModel.Data);
        }

        private void sortButton_Click_1(object sender, EventArgs e)
        {
            currentIndex = 0; // Reset current index
            StartSorting();
            sortingTimer.Enabled = true;
        }
      
    }
}
