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

        public void GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            int[] data = new int[panelWidth * panelHeight];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(panelHeight);
            }
        }

        public void GenerateDrawData()
        {
            int panelWidth = givenNumberPanel.Width;
            int panelHeight = givenNumberPanel.Height;

            givenNumberPanel.Refresh();
            visualizerHelper.GenerateDrawData(sortModel.Data, givenNumberPanel.CreateGraphics(), panelWidth, panelHeight);
        }

        public void ResultDrawData()
        {
            int panelWidth = resultPanel.Width;
            int panelHeight = resultPanel.Height;

            resultPanel.Refresh();
            visualizerHelper.ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), panelWidth, panelHeight);
        }

        public void GenerateRandomNumners(int panelWidth, int panelHeight)
        {
            GenerateRandomNumbers(panelWidth, panelHeight);
        }

        public void GenerateDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.GenerateDrawData(data, graphics, panelWidth, panelHeight);
        }

        public void ResultDrawData(int[] data, Graphics graphics, int panelWidth, int panelHeight)
        {
            visualizerHelper.ResultDrawData(data, graphics, panelWidth, panelHeight);
        }

        private void generateNumberButton_Click(object sender, EventArgs e)
        {
            int panelHeight = givenNumberPanel.Height;
            int panelWidth = givenNumberPanel.Width;
            GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            StartSorting();
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
                ResultDrawData();
            }
        }

        private void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < sortModel.Data.Length - 1)
            {
                if (InsertionSortStep())
                {
                    ResultDrawData();
                }
                else
                {
                    sortingTimer.Stop();
                    isSorting = false;
                }
            }
        }

        private bool InsertionSortStep()
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

        int[] ISortVisualizer.GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            return visualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
        }
    }
}
