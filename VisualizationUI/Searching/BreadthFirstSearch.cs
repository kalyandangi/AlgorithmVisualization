using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualizationLibrary.SearchVisualizer;

namespace VisualizationUI.Searching
{
    public partial class BreadthFirstSearch : Form
    {
        private  List<int> data;
        private  SearchVisualizerHelper searchVisualizerHelper;
        private  OperationBreadthFirstSearch operationBreadthFirstSearch;
        public BreadthFirstSearch()
        {
            
            InitializeComponent();
            data = new List<int>();
            searchVisualizerHelper = new SearchVisualizerHelper();
            operationBreadthFirstSearch =null; // Initialize it here or pass the necessary parameters



        }

        private void generateRandomNumbersBreadthFirstSearchButton_Click(object sender, EventArgs e)
        {
            int panelWidth = generatedNumbersBreadthFirstSearchPanel.Width;
            int panelHeight = generatedNumbersBreadthFirstSearchPanel.Height;

            int[] generatedData = searchVisualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
            data.Clear();
            data.AddRange(generatedData);
            DrawDataOnPanel(generatedData);
            operationBreadthFirstSearch = new OperationBreadthFirstSearch(generatedData);
        }
        private void DrawDataOnPanel(int[] dataToDraw)
        {
            generatedNumbersBreadthFirstSearchPanel.Controls.Clear();

            if (dataToDraw != null && dataToDraw.Length > 0)
            {
                int barWidth = generatedNumbersBreadthFirstSearchPanel.Width / dataToDraw.Length;

                for (int i = 0; i < dataToDraw.Length; i++)
                {
                    int barHeight = (int)((dataToDraw[i] / (double)dataToDraw.Max()) * generatedNumbersBreadthFirstSearchPanel.Height);

                    Panel rectangle = new Panel
                    {
                        Width = barWidth,
                        Height = barHeight,
                        BackColor = Color.Blue
                    };

                    rectangle.Location = new Point(i * barWidth, generatedNumbersBreadthFirstSearchPanel.Height - rectangle.Height);

                    generatedNumbersBreadthFirstSearchPanel.Controls.Add(rectangle);

                }

            }
        }
        private void smallestNumberBreadthFirstSearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationBreadthFirstSearch.FindSmallestNumberIndices, "The smallest number is");

        }

        private void largestNumberBreadthFirstSearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationBreadthFirstSearch.FindLargestNumberIndices, "The largest number is");
        }

        private void PerformSearch(Func<int[], List<int>> searchFunction, string message)
        {
            if (ValidateData())
            {
                List<int> resultIndices = searchFunction(data.ToArray());
                SearchVisualizerHelper.DisplaySearchResult(data, message, resultIndices);
            }
        }
        private void repeatedNumberBreadthFirstSearchButton_Click(object sender, EventArgs e)
        {

            if (ValidateData())
            {
                Dictionary<int, List<int>> repeatedNumberPositions = operationBreadthFirstSearch.FindRepeatedNumbersAndPositions(data.ToArray());
                DisplayRepeatedNumberResult(repeatedNumberPositions);
            }
        }

        private void totalNumberBreadthFirstSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int totalUniqueValues = operationBreadthFirstSearch.CountTotalUniqueValues(data.ToArray());
                MessageBox.Show($"Total Number of Unique Values:{totalUniqueValues}");
            }
        }
        private int GetSearchValue()
        {
            return SearchVisualizerHelper.GetSearchValue(SearchBreadthFirstSearchTextBox.Text);
        }
        private void searchBreadthFirstSearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int searchValue = GetSearchValue();
                if (searchValue != int.MinValue)
                {
                    List<int> positions = operationBreadthFirstSearch.FindOccurrences(data.ToArray(), searchValue);
                    DisplaySearchResult("Search Value Found", positions);
                }
            }

        }
        private void DisplaySearchResult(string message, List<int> positions)
        {
            SearchVisualizerHelper.DisplaySearchResult(data, message, positions);
        }
        private void DisplayRepeatedNumberResult(Dictionary<int, List<int>> repeatedNumberPositions)
        {
            DisplaySearchForm displayForm = new DisplaySearchForm();
            displayForm.DisplayRepeatedNumberResult(repeatedNumberPositions);
            displayForm.Show();
        }
        private bool ValidateData()
        {
            if(data != null && data.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please generate random numbers first,");
                    return false;
            }
        }
    }
}
