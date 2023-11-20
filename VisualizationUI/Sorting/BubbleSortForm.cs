using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationLibrary.Models;
using VisualizationLibrary.SortVisualizer;
using static System.Net.Mime.MediaTypeNames;

namespace VisualizationUI.Sorting
{
    public partial class BubbleSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private SortModel sortModel = new SortModel();
        private Random random = new Random();
        public Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        public bool isSorting = false;

        public SortModel SortModel
        {
            get { return sortModel; }
            set { sortModel = value; }
        }
        public BubbleSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 100; // Adjust the timer interval as needed
            sortingTimer.Tick += SortStep;
        }
        public void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < sortModel.Data?.Length - 1)
            {
                if (sortModel.Data?[currentIndex] > sortModel.Data?[currentIndex + 1])
                {
                    SwapElements(currentIndex, currentIndex + 1);
                    sortModel.IsSortingInProgress = true; // Set sorting in progress
                    ResultDrawData(); // Update UI after each swap
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
                    isSorting = false;
                    sortModel.IsSortingInProgress = false; // Set sorting as completed
                    ResultDrawData(); // Update UI after the last pass
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

        public void GenerateDrawData()
        {
            int panelWidth = givenNumberPanel.Width;
            int panelHeight = givenNumberPanel.Height;

            givenNumberPanel.Refresh();
            visualizerHelper.GenerateDrawData(sortModel.Data, givenNumberPanel.CreateGraphics(), panelWidth, panelHeight);
            // Display the generated data in the givennumbergroupbox
            DisplayGeneratedData(sortModel.Data);
        }

        public void ResultDrawData()
        {
            int panelWidth = resultPanel.Width;
            int panelHeight = resultPanel.Height;

            resultPanel.Refresh();
            if (sortModel.Data != null) // Ensure Data is not null
            {
                visualizerHelper.ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), panelWidth, panelHeight);
                // Append the sorted data to the sortRichTextBox
                DisplaySortedData(sortModel.Data);
            }
            
        }

        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.GenerateDrawData(data, graphics, panelWidth, panelHeight);
        }

        public void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.ResultDrawData(data, graphics, panelWidth, panelHeight);
        }

        public void StartSorting()
        {
            if (!sortModel.IsSortingInProgress)
            {
                isSorting = true;
                sortingTimer.Start();
            }
            else
            {
                sortingTimer.Stop();
                isSorting = false;
                ResultDrawData(); // Display the final result after sorting
            
            }
        }

        public int[] GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            return visualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
        }

        private void generateNumberButton_Click_1(object sender, EventArgs e)
        {
            int panelHeight = givenNumberPanel.Height;
            int panelWidth = givenNumberPanel.Width;
            sortModel.Data = GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData();
           
        }
        private void DisplayGeneratedData(int[] data)
        {
            // Clear the existing text
            givenNumberRichTextBox.Clear();

            // Display the generated random numbers in the richTextBox
            foreach (var number in data)
            {
                givenNumberRichTextBox.AppendText(number.ToString() + " ");
            }
        }
        private void DisplaySortedData(int[] data)
        {
            // Clear the existing text
            sortRichTextBox.Clear();

            // Display the generated random numbers in the richTextBox
            foreach (var number in data)
            {
                sortRichTextBox.AppendText(number.ToString() + " ");
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            StartSorting();
        }

        public void DisplayGeneratedData(int[] data, System.Windows.Controls.RichTextBox richTextBox)
        {
            visualizerHelper.DisplayGeneratedData(data, richTextBox);
        }

        public void DisplaySortedData(int[] data, System.Windows.Controls.RichTextBox richTextBox)
        {
            visualizerHelper.DisplaySortedData(data, richTextBox);
        }
    }
}


