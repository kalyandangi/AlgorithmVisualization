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
    public partial class RadixSortForm : Form, ISortVisualizer
    {

        private SortVisualizerHelper visualizerHelper = new SortVisualizerHelper();
        private SortModel sortModel = new SortModel();
        private Random random = new Random();
        int currentExp = 1; //// Added to keep track of the current radix
        private Timer sortingTimer = new Timer();
        private bool isSorting = false;


        public SortModel SortModel
        {
            get { return sortModel; }
            set { sortModel = value; }
        }
        public RadixSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 1000; // Adjust the timer interval as needed
            sortingTimer.Tick += SortStep;
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

        private void generateNumberButton_Click(object sender, EventArgs e)
        {
            int panelHeight = givenNumberPanel.Height;
            int panelWidth = givenNumberPanel.Width;
            sortModel.Data = GenerateRandomNumbers(panelWidth, panelHeight);
            GenerateDrawData();

            // Display the generated data in the givennumbergroupbox
            DisplayGeneratedData(sortModel.Data);
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

        private void sortButton_Click(object sender, EventArgs e)
        {
            StartSorting();

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
        private void AppendSortedDataToRichTextBox(int[] data)
        {
            // Append the sorted data to the richTextBox
            sortRichTextBox.AppendText("Step: " + currentExp.ToString() + "\n");
            foreach (var number in data)
            {
                sortRichTextBox.AppendText(number.ToString() + " ");
            }
            sortRichTextBox.AppendText("\n\n");
        }
        private void DisplaySortedDataInRichTextBox(int[] data)
        {
            // Clear the existing text
            sortRichTextBox.Clear();

            // Display the final sorted data in the richTextBox
            foreach (var number in data)
            {
                sortRichTextBox.AppendText(number.ToString() + " ");
            }
        }
        private void StartSorting()
        {
            if (!isSorting)
            {
                currentExp = 1; // Reset the radix for a new sort
                isSorting = true;
                sortingTimer.Start();
            }
            else
            {
                sortingTimer.Stop();
                isSorting = false;
                ResultDrawData();
                DisplaySortedData(sortModel.Data);
            }
        }

        private void SortStep(object sender, EventArgs e)
        {
            if (currentExp <= GetMax(sortModel.Data))
            {
                RadixSortStep();
                ResultDrawData();
                DisplaySortedData(sortModel.Data);

                // Append the sorted data to the sortRichTextBox
                AppendSortedDataToRichTextBox(sortModel.Data);

                currentExp *= 10; // Move to the next radix
            }
            else
            {
                sortingTimer.Stop();
                ResultDrawData();
                DisplaySortedData(sortModel.Data);
                DisplaySortedDataInRichTextBox(sortModel.Data); // Display the final sorted data in the richTextBox
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

