using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VisualizationLibrary.SearchVisualizer;

namespace VisualizationUI.Searching
{
    public partial class LinearSearch : Form
    {
        private readonly List<int> data;
        private readonly OperationLinearSearch operationLinearnumberSearch;
        private readonly SearchVisualizerHelper searchVisualizerHelper;
        public LinearSearch()
        {
            InitializeComponent();
            data = new List<int>();
            operationLinearnumberSearch = new OperationLinearSearch();
            searchVisualizerHelper = new SearchVisualizerHelper();
        }

        private void generateRandomNumbersLinearSearchButton_Click(object sender, EventArgs e)
        {
            int panelWidth = generatedNumbersLinearSearchPanel.Width;
            int panelHeight = generatedNumbersLinearSearchPanel.Height;

            int[] generatedData = searchVisualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
            data.Clear(); // Clear the previous data
            data.AddRange(generatedData); // Add the newly generated data
            DrawDataOnPanel(generatedData);
        }

        private void smallestNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationLinearnumberSearch.FindSmallestNumberIndices, "The smallest number is");
        }

        private void largestNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationLinearnumberSearch.FindLargestNumberIndices, "The largest number is");
        }

        private void repeatedNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Dictionary<int, List<int>> repeatedNumberPositions = operationLinearnumberSearch.FindRepeatedNumbersAndPositions(data.ToArray());
                DisplayRepeatedNumberResult(repeatedNumberPositions);
            }
        }

        private void totalNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int totalUniqueValues = operationLinearnumberSearch.CountTotalUniqueValues(data.ToArray());
                MessageBox.Show($"Total Number of Unique Values: {totalUniqueValues}");
            }
        }

        private void searchLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int searchValue = GetSearchValue();
                if (searchValue != int.MinValue)
                {
                    List<int> positions = operationLinearnumberSearch.FindOccurrences(data.ToArray(), searchValue);
                    DisplaySearchResult("Search Value Found", positions);
                }
            }
        }

        private void DrawDataOnPanel(int[] dataToDraw)
        {
            generatedNumbersLinearSearchPanel.Controls.Clear(); // Clear previous drawings on the panel

            if (dataToDraw != null && dataToDraw.Length > 0)
            {
                int barWidth = generatedNumbersLinearSearchPanel.Width / dataToDraw.Length;

                for (int i = 0; i < dataToDraw.Length; i++)
                {
                    int barHeight = (int)((dataToDraw[i] / (double)dataToDraw.Max()) * generatedNumbersLinearSearchPanel.Height);

                    Panel rectangle = new Panel
                    {
                        Width = barWidth,
                        Height = barHeight,
                        BackColor = Color.Blue
                    };

                    rectangle.Location = new Point(i * barWidth, generatedNumbersLinearSearchPanel.Height - rectangle.Height);

                    generatedNumbersLinearSearchPanel.Controls.Add(rectangle);
                }
            }
        }

        private void DisplaySearchResult(string message, List<int> positions)
        {
            SearchVisualizerHelper.DisplaySearchResult(data, message, positions);
        }

        private bool ValidateData()
        {
            if (data != null && data.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please generate random numbers first.");
                return false;
            }
        }

        private void PerformSearch(Func<int[], List<int>> searchFunction, string message)
        {
            if (ValidateData())
            {
                List<int> resultIndices = searchFunction(data.ToArray());
                SearchVisualizerHelper.DisplaySearchResult(data, message, resultIndices);
            }
        }

        private int GetSearchValue()
        {
            return SearchVisualizerHelper.GetSearchValue(SearchLinearSearchTextBox.Text);
        }

        // Move this method to DisplaySearchForm
        private void DisplayRepeatedNumberResult(Dictionary<int, List<int>> repeatedNumberPositions)
        {
            DisplaySearchForm displayForm = new DisplaySearchForm();
            displayForm.DisplayRepeatedNumberResult(repeatedNumberPositions);
            displayForm.Show();
        }
    }
}