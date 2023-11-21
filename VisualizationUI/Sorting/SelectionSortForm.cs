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
        private SortModel sortModel = new SortModel();
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        private bool isSorting = false;

        public SortModel SortModel
        {
            get { return sortModel; }
            set { sortModel = value; }
        }
        public SelectionSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 100; // Adjust the timer interval as needed
            sortingTimer.Tick += SortStep;
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
                    isSorting = false;
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

        private void StartSorting()
        {
            if (!isSorting)
            {
                isSorting = true;
                sortingTimer.Start();
            }
            else
            {
                sortingTimer.Stop();
                isSorting = false;
                ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);
                // Convert array to string and set it to WinForms RichTextBox
                sortRichTextBox.Text = string.Join(" ", sortModel.Data);
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
            StartSorting();
        }

        
    }
}


