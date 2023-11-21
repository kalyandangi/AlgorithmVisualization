using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.SortVisualizer;
using VisualizationLibrary.Models;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using Timer = System.Windows.Forms.Timer;


namespace VisualizationUI.Sorting
{
    public partial class InsertionSortForm : Form, ISortVisualizer
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

        public InsertionSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 1; // Adjust the timer interval as needed
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
        int[] ISortVisualizer.GenerateRandomNumbers(int panelWidth, int panelHeight)
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
            visualizerHelper.StartSorting(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);
        }

        private void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < sortModel.Data.Length - 1)
            {
                if (InsertionSortStep())
                {
                    ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);
                    // Convert array to string and set it to WinForms RichTextBox
                    sortRichTextBox.Text = string.Join(" ", sortModel.Data);
                }
                else
                {
                    sortingTimer.Enabled = false;
                    isSorting = false;
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

            while (currentIndex >= 0 && sortModel.Data[currentIndex] > key)
            {
                sortModel.Data[currentIndex + 1] = sortModel.Data[currentIndex];
                currentIndex--;
            }

            sortModel.Data[currentIndex + 1] = key;
            currentIndex++;

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
            StartSorting();
        }

       
    }
}
