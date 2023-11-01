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

namespace VisualizationUI
{
    public partial class BubbleSortForm : Form
    {
        public BubbleSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 100; // Adjust the timer interval as needed
            sortingTimer.Tick += SortStep;
        }

        int[]? data;
        private Random random = new Random();

        private void GenerateRandomNumbers()
        {
            int arraySize = givenNumberPanel.Width;
            data = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                data[i] = random.Next(givenNumberPanel.Height);
            }
        }
        private void GenerateDrawData()
        {
            if (data == null) return;
            using (Graphics g = givenNumberPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < data.Length; i++)
                {
                    int barWidth = givenNumberPanel.Width / data.Length;
                    int barHeight = data[i];

                    Rectangle bar = new Rectangle(i * barWidth, givenNumberPanel.Height - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }

        }
        private void ResultDrawData()
        {
            if (data == null) return;
            using (Graphics g = resultPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < data.Length; i++)
                {
                    int barWidth = resultPanel.Width / data.Length;
                    int barHeight = data[i];

                    Rectangle bar = new Rectangle(i * barWidth, resultPanel.Height - barHeight, barWidth, barHeight);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }

        }

        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        private bool isSorting = false;
        private void SortStep(object sender, EventArgs e)

        {

            int currentIndex = 0;
            if (currentIndex < data?.Length - 1)
            {
                if (data?[currentIndex] > data?[currentIndex + 1])
                {
                    int temp = data[currentIndex];
                    data[currentIndex] = data[currentIndex + 1];
                    data[currentIndex + 1] = temp;
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
                }
            }
            ResultDrawData();
        }

        private bool BubbleSortStep()
        {
            bool swapped = false;
            for (int i = 0; i < data?.Length - 1; i++)
            {
                if (data?[i] > data?[i + 1])
                {
                    int temp = data[i];
                    data[i] = data[i + 1];
                    data[i + 1] = temp;
                    swapped = true;
                }
            }
            return swapped;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (!isSorting)
            {
                isSorting = true;
                sortingTimer.Start();
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateRandomNumbers();
            GenerateDrawData();
        }
    }
}
