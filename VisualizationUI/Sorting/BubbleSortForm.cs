using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.SortVisualizer;
using VisualizationLibrary.Models;
namespace VisualizationUI.Sorting
{
    public partial class BubbleSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private Random random = new Random();
        public Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        public SortModel sortModel { get; set; } = new SortModel();

        public BubbleSortForm()
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
            if (currentIndex < sortModel.Data?.Length - 1)
            {
                if (sortModel.Data?[currentIndex] > sortModel.Data?[currentIndex + 1])
                {
                    SwapElements(currentIndex, currentIndex + 1);
                    sortModel.IsSortingInProgress = true; // Set sorting in progress
                    ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);

                    // Convert array to string and set it to WinForms RichTextBox
                    sortRichTextBox.Text = string.Join(" ", sortModel.Data);
                }
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                if (!BubbleSortStep())
                {
                    // Sorting is complete
                    sortingTimer.Stop();
                    // isSorting = false;
                    sortModel.IsSortingInProgress = false; // Set sorting as completed
                    ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);

                    // Convert array to string and set it to WinForms RichTextBox
                    sortRichTextBox.Text = string.Join(" ", sortModel.Data);
                }
            }
        }
        public bool BubbleSortStep()
        {
            bool swapped = false;

            for (int i = 0; i < sortModel?.Data.Length - 1; i++)
            {
                if (sortModel?.Data[i] > sortModel?.Data[i + 1])
                {
                    SwapElements(i, i + 1);
                    swapped = true;
                }
            }

            // Reset the swapped flag for the next pass
            return swapped;
        }


        private void SwapElements(int index1, int index2)
        {
            int temp = sortModel.Data[index1];
            sortModel.Data[index1] = sortModel.Data[index2];
            sortModel.Data[index2] = temp;
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

        private void sortButton_Click(object sender, EventArgs e)
        {
            currentIndex = 0; // Reset current index
            StartSorting();
            sortingTimer.Enabled = true;
        }

    }
}


