using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizationUI
{
    public partial class SelectionSortForm : Form
    {
        VisualizationLibrary.Models.SelectionSortModel selectionSortModel = new VisualizationLibrary.Models.SelectionSortModel();
        public VisualizationLibrary.Models.SelectionSortModel SelectionSortModel
        {
            get { return selectionSortModel; }
            set { selectionSortModel = value; }
        }

        public SelectionSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 1; // Adjust the timer interval as needed
            sortingTimer.Tick += SortStep;
        }

        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        private bool isSorting = false;

        public void GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            int arraySize = 100;
            selectionSortModel.Data = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                selectionSortModel.Data[i] = random.Next(panelHeight);
            }
        }

        public void GenerateDrawData()
        {
            if (selectionSortModel.Data == null) return;
            using (Graphics g = givenNumberPanel.CreateGraphics())
            {
                g.Clear(Color.White);
                for (int i = 0; i < selectionSortModel.Data.Length; i++)
                {
                    int barWidth = givenNumberPanel.Width / selectionSortModel.Data.Length;
                    int barHeight = selectionSortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, givenNumberPanel.Height - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }
        }

        public void ResultDrawData()
        {
            if (selectionSortModel.Data == null) return;
            using (Graphics g = resultPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < selectionSortModel.Data.Length; i++)
                {
                    int barWidth = resultPanel.Width / selectionSortModel.Data.Length;
                    int barHeight = selectionSortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, resultPanel.Height - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }
        }

        public void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < selectionSortModel.Data?.Length - 1)
            {
                int minIndex = currentIndex;
                for (int i = currentIndex + 1; i < selectionSortModel?.Data?.Length; i++)
                {
                    if (selectionSortModel.Data[i] < selectionSortModel.Data[minIndex])
                    {
                        minIndex = i;
                    }
                }

                int temp = selectionSortModel.Data[currentIndex];
                selectionSortModel.Data[currentIndex] = selectionSortModel.Data[minIndex];
                selectionSortModel.Data[minIndex] = temp;
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
            ResultDrawData();
        }

        public bool SelectionSortStep()
        {
            if (currentIndex >= selectionSortModel.Data.Length - 1)
            {
                return false; // Sorting is complete
            }

            int minIndex = currentIndex;
            for (int i = currentIndex + 1; i < selectionSortModel.Data.Length; i++)
            {
                if (selectionSortModel.Data[i] < selectionSortModel.Data[minIndex])
                {
                    minIndex = i;
                }
            }

            int temp = selectionSortModel.Data[currentIndex];
            selectionSortModel.Data[currentIndex] = selectionSortModel.Data[minIndex];
            selectionSortModel.Data[minIndex] = temp;

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
                ResultDrawData();
            }
        }

        private void selectionSortGenerateInputButton_Click(object sender, EventArgs e)
        {
            int panelWidth = givenNumberPanel.Width;
            int panelHeight = givenNumberPanel.Height;
            GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData();
        }

        private void selectionSortOutputButton_Click(object sender, EventArgs e)
        {
            StartSorting();
        }
    }
}

