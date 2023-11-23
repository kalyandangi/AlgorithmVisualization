using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.SortVisualizer;
using VisualizationLibrary.Models;

namespace VisualizationUI.Sorting
{
    public partial class InsertionSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        public SortModel sortModel { get; set; } = new SortModel();

        public InsertionSortForm()
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

        
        private void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < sortModel.Data.Length - 1)
            {
                if (InsertionSortStep())
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

        public bool InsertionSortStep()
        {
            if (currentIndex >= sortModel.Data.Length - 1)
            {
                return false; // Sorting is complete
            }

            int keyIndex = currentIndex + 1;
            int key = sortModel.Data[keyIndex];
            int tempIndex = currentIndex;

            while (tempIndex >= 0 && sortModel.Data[tempIndex] > key)
            {
                // Move the elements to visualize the insertion step
                sortModel.Data[tempIndex + 1] = sortModel.Data[tempIndex];
                tempIndex--;

                // Draw the current state to highlight the selected element
                ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);
                sortRichTextBox.Text = string.Join(" ", sortModel.Data);

            }
            sortModel.Data[tempIndex + 1] = key;

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
