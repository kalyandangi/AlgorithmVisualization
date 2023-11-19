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

namespace VisualizationUI.Sorting
{
    public partial class QuickSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private SortModel sortModel = new SortModel();
        private Random random = new Random();
        private int currentIndex = 0;
        public Timer sortingTimer = new Timer();
        public bool isSorting = false;
        public QuickSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 1;
            sortingTimer.Tick += SortStep;
        }
        public SortModel SortModel
        {
            get { return sortModel; }
            set { sortModel = value; }
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
                if (!QuickSortStep(0, sortModel.Data.Length - 1))
                {
                    // Sorting is complete
                    sortingTimer.Stop();
                    isSorting = false;
                    sortModel.IsSortingInProgress = false; // Set sorting as completed
                    
                }
                ResultDrawData(); // Update UI after the last pass
            }

        }

        public bool QuickSortStep(int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(low, high);

                QuickSortStep(low, partitionIndex - 1);
                QuickSortStep(partitionIndex + 1, high);

                return true;
            }

            return false;
        }

        private int Partition(int low, int high)
        {
            int pivot = sortModel.Data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (sortModel.Data[j] < pivot)
                {
                    i++;
                    SwapElements(i, j);
                }
            }

            SwapElements(i + 1, high);
            return i + 1;
        }

        private void SwapElements(int index1, int index2)
        {
            int temp = sortModel.Data[index1];
            sortModel.Data[index1] = sortModel.Data[index2];
            sortModel.Data[index2] = temp;
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
        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.GenerateDrawData(data, graphics, panelWidth, panelHeight);
        }

        public void GenerateDrawData()
        {
            int panelWidth = givenNumberPanel.Width;
            int panelHeight = givenNumberPanel.Height;

            givenNumberPanel.Refresh();
            visualizerHelper.GenerateDrawData(sortModel.Data, givenNumberPanel.CreateGraphics(), panelWidth, panelHeight);
        }

        public int[] GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            return visualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
        }

        public void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.ResultDrawData(data, graphics, panelWidth, panelHeight);
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
