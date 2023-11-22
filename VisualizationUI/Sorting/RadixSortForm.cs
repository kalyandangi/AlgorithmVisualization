using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.SortVisualizer;
using VisualizationLibrary.Models;
using System.Linq;

namespace VisualizationUI.Sorting
{
    public partial class RadixSortForm : Form, ISortVisualizer
    {
        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private Random random = new Random();
        private Timer sortingTimer = new Timer();
        private int currentIndex = 0;
        private int currentExp = 1;
        public SortModel sortModel { get; set; } = new SortModel();

        public RadixSortForm()
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

        private void StartSorting()
        {
            visualizerHelper.StartSorting(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height, SortStep);
        }

        private void generateNumberButton_Click(object sender, EventArgs e)
        {
            int panelHeight = givenNumberPanel.Height;
            int panelWidth = givenNumberPanel.Width;
            sortModel.Data = GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData(sortModel.Data, givenNumberPanel.CreateGraphics(), givenNumberPanel.Width, givenNumberPanel.Height);
            // Convert array to string and set it to WinForms RichTextBox
            givenNumberRichTextBox.Text = string.Join(" ", sortModel.Data);

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            currentIndex = 0; // Reset current index
            StartSorting();
            sortingTimer.Enabled = true;

        }
        
      

        private void SortStep(object sender, EventArgs e)
        {
            if (currentExp <= GetMax(sortModel.Data))
            {
                RadixSortStep();
                ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);

                // Convert array to string and set it to WinForms RichTextBox
                sortRichTextBox.Text = string.Join(" ", sortModel.Data);
                currentExp *= 10; // Move to the next radix
            }
            else
            {
                sortingTimer.Stop();
                ResultDrawData(sortModel.Data, resultPanel.CreateGraphics(), resultPanel.Width, resultPanel.Height);

                // Convert array to string and set it to WinForms RichTextBox
                sortRichTextBox.Text = string.Join(" ", sortModel.Data);
            }
        }

        private void RadixSortStep()
        {
            int n = sortModel.Data.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < 10; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                count[(sortModel.Data[i] / currentExp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(sortModel.Data[i] / currentExp) % 10] - 1] = sortModel.Data[i];
                count[(sortModel.Data[i] / currentExp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                sortModel.Data[i] = output[i];
            }
        }

        private int GetMax(int[] array)
        {
            return array.Max();
        }

       
    }
}

