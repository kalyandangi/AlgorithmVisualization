using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.SortVisualizer;
using VisualizationLibrary.Models;


namespace VisualizationUI.Sorting
{
    public partial class HeapSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        public SortModel sortModel { get; set; } = new SortModel();
        public HeapSortForm()
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

        private void StartSorting()
        {
            visualizerHelper.StartSorting(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height, SortStep);
        }
        private void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < sortModel.Data.Length - 1)
            {
                if (HeapSortStep())
                {
                    ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);
                    sortRichTextBox.Text = string.Join(" ", sortModel.Data);
                    currentIndex++;
                }
                else
                {
                    sortingTimer.Enabled = false;
                    sortRichTextBox.Text = string.Join(" ", sortModel.Data);
                }
            }
        }

        public bool HeapSortStep()
        {
            if (currentIndex >= sortModel.Data.Length - 1)
            {
                return false; // Sorting is complete
            }

            int n = sortModel.Data.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(n, i);
            }
                

            for (int i = n - 1; i > 0; i--)
            {
                int temp = sortModel.Data[0];
                sortModel.Data[0] = sortModel.Data[i];
                sortModel.Data[i] = temp;

                Heapify(i, 0);
            }

            return true;
        }

        private void Heapify(int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && sortModel.Data[left] > sortModel.Data[largest])
                largest = left;

            if (right < n && sortModel.Data[right] > sortModel.Data[largest])
                largest = right;

            if (largest != i)
            {
                int swap = sortModel.Data[i];
                sortModel.Data[i] = sortModel.Data[largest];
                sortModel.Data[largest] = swap;

                Heapify(n, largest);
            }
        }

        private void generateNumberButton_Click(object sender, EventArgs e)
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
