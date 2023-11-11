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
using VisualizationLibrary;

namespace VisualizationUI
{

    public partial class BubbleSortForm : Form
    {
        VisualizationLibrary.Models.BubbleSortModel bubbleSortModel = new VisualizationLibrary.Models.BubbleSortModel();
        public VisualizationLibrary.Models.BubbleSortModel BubbleSortModel
        {
            get { return bubbleSortModel; }
            set { bubbleSortModel = value; }
        }


        public BubbleSortForm()
        {
         
            InitializeComponent();
            sortingTimer.Interval = 1; // Adjust the timer interval as needed
            sortingTimer.Tick += SortStep;
        }
        // Array to hold data for sorting
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        private bool isSorting = false;

        public void GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            int arraySize = 100;
            bubbleSortModel.Data = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                bubbleSortModel.Data[i] = random.Next(givenNumberPanel.Height);
            }
        }
        public void GenerateDrawData()
        {
            if (bubbleSortModel.Data == null) return;
            using (Graphics g = givenNumberPanel.CreateGraphics())
            {
                g.Clear(Color.White);
                // Draw bars based on data values
                for (int i = 0; i < bubbleSortModel.Data.Length; i++)
                {
                    int barWidth = givenNumberPanel.Width / bubbleSortModel.Data.Length;
                    int barHeight = bubbleSortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, givenNumberPanel.Height - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }

        }
        public void ResultDrawData()
        {
            if (bubbleSortModel.Data == null) return;
            using (Graphics g = resultPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < bubbleSortModel.Data.Length; i++)
                {
                    int barWidth = resultPanel.Width / bubbleSortModel.Data.Length;
                    int barHeight = bubbleSortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, resultPanel.Height - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }

        }

        public void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < bubbleSortModel.Data?.Length - 1)
            {
                if (bubbleSortModel.Data?[currentIndex] > bubbleSortModel.Data?[currentIndex + 1])
                {
                    int temp = bubbleSortModel.Data[currentIndex];
                    bubbleSortModel.Data[currentIndex] = bubbleSortModel.Data[currentIndex + 1];
                    bubbleSortModel.Data[currentIndex + 1] = temp;
                    bubbleSortModel.IsSortingInProgress = true; // Set sorting in progress
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
                    bubbleSortModel.IsSortingInProgress = false; // Set sorting as completed
                }
            }
            ResultDrawData();
        }


        public bool BubbleSortStep()
        {
            bool swapped = false;
            for (int i = 0; i < bubbleSortModel.Data?.Length - 1; i++)
            {
                if (bubbleSortModel.Data?[i] > bubbleSortModel.Data?[i + 1])
                {
                    int temp = bubbleSortModel.Data[i];
                    bubbleSortModel.Data[i] = bubbleSortModel.Data[i + 1];
                    bubbleSortModel.Data[i + 1] = temp;
                    swapped = true;
                }
            }
            return swapped;
        }
        private void StartSorting()
        {
            if (!bubbleSortModel.IsSortingInProgress)
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
        private void sortButton_Click(object sender, EventArgs e)
        {
            StartSorting();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
           int panelWidth = givenNumberPanel.Width;
            int panelHeight = givenNumberPanel.Height;
            GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData();
        }
    }
}
