using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.Models;
using VisualizationLibrary.SortVisualizer;


namespace VisualizationUI
{
    public partial class SelectionSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        public SortModel sortModel { get; set; } = new SortModel();
        public SelectionSortForm()
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
                int minIndex = currentIndex;
                for (int i = currentIndex + 1; i < sortModel?.Data?.Length; i++)
                {
                    if (sortModel.Data[i] < sortModel.Data[minIndex])
                    {
                        minIndex = i;
                    }
                }

                int temp = sortModel.Data[currentIndex];
                sortModel.Data[currentIndex] = sortModel.Data[minIndex];
                sortModel.Data[minIndex] = temp;
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                if (!SelectionSortStep())
                {
                    sortingTimer.Stop();
                    // isSorting = false;
                }
            }
            ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);
            // Convert array to string and set it to WinForms RichTextBox
            sortRichTextBox.Text = string.Join(" ", sortModel.Data);
        }

        public bool SelectionSortStep()
        {
            if (currentIndex >= sortModel.Data.Length - 1)
            {
                return false; // Sorting is complete
            }

            int minIndex = currentIndex;
            for (int i = currentIndex + 1; i < sortModel.Data.Length; i++)
            {
                if (sortModel.Data[i] < sortModel.Data[minIndex])
                {
                    minIndex = i;
                }
            }

            int temp = sortModel.Data[currentIndex];
            sortModel.Data[currentIndex] = sortModel.Data[minIndex];
            sortModel.Data[minIndex] = temp;

            currentIndex++;
            return true;
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