﻿using System;
using System.Drawing;
using System.Windows.Forms;
using VisualizationLibrary.Models;
using VisualizationLibrary.SortVisualizer;


namespace VisualizationUI
{
    public partial class SelectionSortForm : Form, ISortVisualizer
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
        public SelectionSortForm()
        {
            InitializeComponent();
            sortingTimer.Interval = 100; // Adjust the timer interval as needed
            sortingTimer.Tick += SortStep;
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
        public int[] GenerateRandomNumbers(int panelWidth, int panelHeight)
        {
            return visualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
        }
        public void SortStep(object sender, EventArgs e)
        {
            if (currentIndex < sortModel.Data?.Length - 1)
            {
                int minIndex = currentIndex;
                for (int i = currentIndex + 1; i < sortModel?.Data?.Length; i++)
                {
                    if (sortModel.Data[i] < sortModel.Data[minIndex])
                    {
                        minIndex = i;
                    }
                }

                int temp = sortModel.Data[currentIndex];
                sortModel.Data[currentIndex] = sortModel.Data[minIndex];
                sortModel.Data[minIndex] = temp;
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
            if (currentIndex >= sortModel.Data.Length - 1)
            {
                return false; // Sorting is complete
            }

            int minIndex = currentIndex;
            for (int i = currentIndex + 1; i < sortModel.Data.Length; i++)
            {
                if (sortModel.Data[i] < sortModel.Data[minIndex])
                {
                    minIndex = i;
                }
            }

            int temp = sortModel.Data[currentIndex];
            sortModel.Data[currentIndex] = sortModel.Data[minIndex];
            sortModel.Data[minIndex] = temp;

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


