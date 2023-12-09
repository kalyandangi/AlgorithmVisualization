using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationLibrary.SearchVisualizer;

namespace VisualizationUI.Searching
{
    public partial class InterpolationSearch : Form
    {
        private readonly List<int> data;
        private readonly SearchVisualizerHelper searchVisualizerHelper;
        private readonly OperationInterpolationSearch operationInterpolationSearch;
        public InterpolationSearch()
        {
            InitializeComponent();
            data = new List<int>();
            searchVisualizerHelper = new SearchVisualizerHelper();
            operationInterpolationSearch = new OperationInterpolationSearch();
        }

        private void generateRandomNumbersInterpolationSearchButton_Click(object sender, EventArgs e)
        {
            int panelWidth = generatedNumbersInterpolationSearchPanel.Width;
            int panelHeight = generatedNumbersInterpolationSearchPanel.Height;

            int[] generatedData = searchVisualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
            data.Clear();
            data.AddRange(generatedData);
            DrawDataOnPanel(generatedData);
        }

        private void DrawDataOnPanel(int[] dataToDraw)
        {
            generatedNumbersInterpolationSearchPanel.Controls.Clear();
            if (dataToDraw != null && dataToDraw.Length > 0)
            {
                int barWidth = generatedNumbersInterpolationSearchPanel.Width / dataToDraw.Length;
                for (int i = 0; i < dataToDraw.Length; i++)
                {
                    int barHeight = (int)((dataToDraw[i] / (double)dataToDraw.Max()) * generatedNumbersInterpolationSearchPanel.Height);

                    Panel rectangle = new Panel
                    {
                        Width = barWidth,
                        Height = barHeight,
                        BackColor = Color.Blue,
                    };
                    rectangle.Location = new Point(i * barWidth, generatedNumbersInterpolationSearchPanel.Height - rectangle.Height);
                    generatedNumbersInterpolationSearchPanel.Controls.Add(rectangle);
                }
            }
        }

        private void smallestNumberInterpolationSearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationInterpolationSearch.FindSmallestNumberIndices, "The Smallest Number is");
        }

        private void largestNumberInterpolationSearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationInterpolationSearch.FindLargestNumberIndices, "The Largest Number is");

        }

        private void PerformSearch(Func<int[], List<int>> searchFunction, string message)
        {
            if (Validate())
            {
                List<int> resultIndices = searchFunction(data.ToArray());
                SearchVisualizerHelper.DisplaySearchResult(data, message, resultIndices);
            }
        }

        private void totalNumberInterpolationSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int todtalUniquesValues = operationInterpolationSearch.CountTotalUniqueValues(data.ToArray());
                MessageBox.Show($"Total Number of Unique Values: {todtalUniquesValues}");
            }

        }

        private void searchInterpolationSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int searchValue = GetSearchValue();
                if (searchValue != int.MinValue)
                {
                    List<int> positions = operationInterpolationSearch.FindOccurances(data.ToArray(), searchValue);
                    DisplaySearchResult("Search Value Found", positions);
                }
            }
        }
        private void DisplaySearchResult(string message, List<int> positions)
        {
            SearchVisualizerHelper.DisplaySearchResult(data, message, positions);
        }

        private int GetSearchValue()
        {
            return SearchVisualizerHelper.GetSearchValue(SearchInterpolationSearchTextBox.Text);
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

        private void repeatedNumberInterpolationSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Dictionary<int, List<int>> repeatedNumberPositions = operationInterpolationSearch.FindRepeatedNumbersAndPositions(data.ToArray());
                DisplayRepeatedNumberResult(repeatedNumberPositions);
            }
        }
        private void DisplayRepeatedNumberResult(Dictionary<int, List<int>> repeatedNumberPositions)
        {
            DisplaySearchForm displayForm = new DisplaySearchForm();
            displayForm.DisplayRepeatedNumberResult(repeatedNumberPositions);
            displayForm.Show();
        }
    }
}
