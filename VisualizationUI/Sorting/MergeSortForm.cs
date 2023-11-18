using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationLibrary.Models;
using VisualizationLibrary.SortVisualizer;

namespace VisualizationUI.Sorting
{
    public partial class MergeSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private SortModel sortModel = new SortModel();
        private Random random = new Random();
        public Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        public bool isSorting = false;

        public MergeSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 100;
            sortingTimer.Tick += SortStep;
        }
        public SortModel SortModel
        {
            get { return sortModel; }
            set { sortModel = value; }
        }
        private void SortStep(object sender, EventArgs e)
        {
            if(sortModel.Data.Length <= 1)
            {
                return;
            }
            int middle = sortModel.Data.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[sortModel.Data.Length - middle];

            Array.Copy(sortModel.Data,0,leftArray,0,middle);
            Array.Copy(sortModel.Data, middle, rightArray, 0, sortModel.Data.Length - middle);


            MergeSortStep(sortModel.Data, leftArray, rightArray);

            ResultDrawData(); // Update UI after each swap

        }
        public void MergeSortStep(int[] result, int[] leftArray, int[] rightArray)
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
        }
        // Helper method to check if an array is sorted
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
        public void GenerateDrawData()
        {
            int panelWidth = givenNumberPanel.Width;
            int panelHeight = givenNumberPanel.Height;

            givenNumberPanel.Refresh();
            visualizerHelper.GenerateDrawData(sortModel.Data, givenNumberPanel.CreateGraphics(), panelWidth, panelHeight);
        }

        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.GenerateDrawData(data, graphics, panelWidth, panelHeight);
        }

        public int[] GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            return visualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
        }
        public void ResultDrawData()
        {
            int panelWidth = resultPanel.Width;
            int panelHeight = resultPanel.Height;

            resultPanel.Refresh();
            if (sortModel.Data != null) // Ensure Data is not null
            {
                visualizerHelper.ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), panelWidth, panelHeight);
            }
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
        private void generateNumberButton_Click(object sender, EventArgs e)
        {
            int panelHeight = givenNumberPanel.Height;
            int panelWidth = givenNumberPanel.Width;
            sortModel.Data = GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            StartSorting();
        }
    }
}
