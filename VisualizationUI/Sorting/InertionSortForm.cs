using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary;

namespace VisualizationUI.Sorting
{
    public partial class InsertionSortForm : Form, ISortVisualizer
    {
        VisualizationLibrary.Models.SortModel sortModel = new VisualizationLibrary.Models.SortModel();
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        private bool isSorting = false;

        public VisualizationLibrary.Models.SortModel SortModel
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
  
        private void GenerateRandomNumbers(int panelWidth, int panelHeigth)
        {
            int arraySize = 100;
            sortModel.Data = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                sortModel.Data[i] = random.Next(givenNumberPanel.Height);
            }
        }

        private void GenerateDrawData()
        {
            if (sortModel.Data == null) return;

            using (Graphics g = givenNumberPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < sortModel.Data.Length; i++)
                {
                    int barWidth = givenNumberPanel.Width / sortModel.Data.Length;
                    int barHeigth = sortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, givenNumberPanel.Height - barHeigth, barWidth, barHeigth);
                    g.FillRectangle(Brushes.Blue, bar);

                }
            }
        }

        private void ResultDrawData()
        {
            if (sortModel.Data == null)
            {
                return;
            }

            using (Graphics g = resultPanel.CreateGraphics())
            {
                g.Clear(Color.White);

                for (int i = 0; i < sortModel.Data.Length; i++)
                {
                    int barWidth = resultPanel.Width / sortModel.Data.Length;
                    int barHeigth = sortModel.Data[i];

                    Rectangle bar = new Rectangle(i * barWidth, resultPanel.Height - barHeigth, barWidth, barHeigth);
                    g.FillRectangle(Brushes.Blue, bar);
                }
            }

        }


        public void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < sortModel.Data.Length-1)
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

        public bool InsertionSortStep()
        {
            if(currentIndex >= sortModel.Data.Length - 1)
            {
                return false; //sorting is complete
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
        private void generateNumberButton_Click(object sender, EventArgs e)
        {
            int panelWidth = givenNumberPanel.Width;
            int panelHeight = givenNumberPanel.Height;
            GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData();

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            StartSorting();
        }

        public void GenerateRandomNumners(int panelWidth, int panelHeight)
        {
            int arraySize = 100;
            sortModel.Data = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                sortModel.Data[i] = random.Next(panelHeight);
            }
        }

        public void GenrateDrawData()
        {
            GenerateDrawData();
        }

        void ResultDrawData()
        {
            ResultDrawData();
        }
    }

}
