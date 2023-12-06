using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using VisualizationLibrary.SearchVisualizer;

namespace VisualizationUI.Searching
{
    public partial class BinarySearch : Form
    {
        private readonly List<int> data;
        private readonly SearchVisualizerHelper searchVisualizerHelper;
        private readonly OperationBinarySearch operationBinarySearch;
        public BinarySearch()
        {
            InitializeComponent();
            data = new List<int>();
            searchVisualizerHelper = new SearchVisualizerHelper();
            operationBinarySearch = new OperationBinarySearch();

        }

        private void generateRandomNumbersBinarySearchButton_Click(object sender, EventArgs e)
        {
            int panelWidth = genereatedNumbersBinarySearchPanel.Width;
            int panelHeight = genereatedNumbersBinarySearchPanel.Height;

            int[] generatedData = searchVisualizerHelper.GenerateRandomNumbers(panelWidth, panelHeight);
            data.Clear();
            data.AddRange(generatedData);
            DrawDataOnPanel(generatedData);
        }

        private void DrawDataOnPanel(int[] dataToDraw)
        {
            genereatedNumbersBinarySearchPanel.Controls.Clear();

            if (dataToDraw != null && dataToDraw.Length > 0)
            {
                int barWidth = genereatedNumbersBinarySearchPanel.Width / dataToDraw.Length;

                for (int i = 0; i < dataToDraw.Length; i++)
                {
                    int barHeight = (int)((dataToDraw[i] / (double)dataToDraw.Max()) * genereatedNumbersBinarySearchPanel.Height);

                    Panel rectangle = new Panel
                    {
                        Width = barWidth,
                        Height = barHeight,
                        BackColor = Color.Blue
                    };

                    rectangle.Location = new Point(i * barWidth, genereatedNumbersBinarySearchPanel.Height - rectangle.Height);

                    genereatedNumbersBinarySearchPanel.Controls.Add(rectangle);

                }

            }
        }

        private void largestNumberBinarySearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationBinarySearch.FindLargestNumberIndices, "The largest number is");
        }

        private void PerformSearch(Func<int[], List<int>> searchFunction, string message)
        {
            if (ValidateData())
            {
                List<int> resultIndices = searchFunction(data.ToArray());
                SearchVisualizerHelper.DisplaySearchResult(data, message, resultIndices);
            }
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

        private void totalNumberBinarySearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                int totalUniqueValues = operationBinarySearch.CountTotalUniqueValues(data.ToArray());
                MessageBox.Show($"Total Number of Unique Values:{totalUniqueValues}");
            }
        }

        private void smallestNumberBinarySearchButton_Click(object sender, EventArgs e)
        {
            PerformSearch(operationBinarySearch.FindSmallestNumberIndices, "The smallest number is");
        }
    }
}
