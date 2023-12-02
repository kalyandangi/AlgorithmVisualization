using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VisualizationLibrary.SearchVisualizer;



namespace VisualizationUI.Searching
{
    public partial class LinearSearch : Form
    {


        private readonly List<int> data;
        private readonly NumberSearch numberSearch;

        public LinearSearch()
        {
            InitializeComponent();


            data = new List<int>();
            numberSearch = new NumberSearch();



        }

        private void generateRandomNumbersLinearSearchButton_Click(object sender, EventArgs e)
        {
            int panelWidth = generatedNumbersLinearSearchPanel.Width;
            int panelHeight = generatedNumbersLinearSearchPanel.Height;

            int[] generatedData = GenerateRandomNumbers(panelWidth, panelHeight);
            DrawDataOnPanel(generatedData);

        }



        private void smallestNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (data != null && data.Count > 0)
            {
                List<int> smallestIndices = numberSearch.FindSmallestNumberIndices(data.ToArray());
                DisplaySearchResult("The smallest number is", smallestIndices);
            }
            else
            {
                MessageBox.Show("Please generate random numbers first.");
            }
        }


        private void largestNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (data != null && data.Count > 0)
            {
                List<int> largestIndices = numberSearch.FindLargestNumberIndices(data.ToArray());
                DisplaySearchResult("The largest number is", largestIndices);
            }
            else
            {
                MessageBox.Show("Please generate random numbers first.");
            }
        }

        private void repeatedNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (data != null && data.Count > 0)
            {
                Dictionary<int, List<int>> repeatedNumberPositions = numberSearch.FindRepeatedNumbersAndPositions(data.ToArray());
                DisplayRepeatedNumberResult(repeatedNumberPositions);
            }
            else
            {
                MessageBox.Show("Please generate random numbers first.");
            }
        }


        private void totalNumberLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (data != null && data.Count > 0)
            {
                int totalUniqueValues = numberSearch.CountTotalUniqueValues(data.ToArray());
                MessageBox.Show($"Total Number of Unique Values: {totalUniqueValues}");
            }
            else
            {
                MessageBox.Show("Please generate random numbers first.");
            }

        }

        private void searchLinearSearchButton_Click(object sender, EventArgs e)
        {
            if (data != null && data.Count > 0)
            {
                int searchValue = GetSearchValue();
                if (searchValue != int.MinValue)
                {
                    List<int> positions = numberSearch.FindOccurrences(data.ToArray(), searchValue);
                    DisplaySearchResult("Search Value Found", positions);
                }
            }
            else
            {
                MessageBox.Show("Please generate random numbers first.");
            }

        }
        private void DrawDataOnPanel(int[] dataToDraw)
        {
            generatedNumbersLinearSearchPanel.Controls.Clear();

            if (dataToDraw != null && dataToDraw.Length > 0)
            {
                double barWidth = generatedNumbersLinearSearchPanel.Width / dataToDraw.Length;

                for (int i = 0; i < dataToDraw.Length; i++)
                {
                    double barHeight = (dataToDraw[i] / (double)dataToDraw.Max()) * generatedNumbersLinearSearchPanel.Height;

                    System.Windows.Forms.Panel rectangle = new System.Windows.Forms.Panel
                    {
                        Width = (int)barWidth,
                        Height = (int)barHeight,
                        BackColor = System.Drawing.Color.Blue
                    };

                    rectangle.Location = new System.Drawing.Point((int)(i * barWidth), generatedNumbersLinearSearchPanel.Height - rectangle.Height);

                    generatedNumbersLinearSearchPanel.Controls.Add(rectangle);
                }
            }
        }



        private int[] GenerateRandomNumbers(int arrayLength, int maxValue)
        {
            return numberSearch.GenerateRandomNumbers(arrayLength, maxValue);
        }

        private void DisplaySearchResult(string message, List<int> positions)
        {
            if (positions.Count > 0)
            {
                string positionsStr = string.Join(", ", positions.Select(pos => pos.ToString()));
                string resultMessage = $"{message}: {data[positions[0]]}\nPosition(s): {positionsStr}";
                MessageBox.Show(resultMessage, "Search Result");
            }
            else
            {
                MessageBox.Show("Search value not found.");
            }
        }

        private void DisplayRepeatedNumberResult(Dictionary<int, List<int>> repeatedNumberPositions)
        {
            StringBuilder summary = new StringBuilder();
            int totalRepeatedValues = repeatedNumberPositions.Count;
            int totalOccurrences = repeatedNumberPositions.Values.Sum(list => list.Count);
            summary.AppendLine($"Total Number of Repeated Values: {totalRepeatedValues}");
            summary.AppendLine($"Total Occurrences: {totalOccurrences}");

            StringBuilder details = new StringBuilder();
            details.AppendLine("Repeated Numbers, Counts, and Positions:");

            int count = 1;
            foreach (var pair in repeatedNumberPositions)
            {
                string positions = string.Join(", ", pair.Value.Select(pos => pos.ToString()));
                details.AppendLine($"{count++}. {pair.Key}: {pair.Value.Count} times at positions {positions}");
            }

            DisplayResultForm form = new DisplayResultForm($"{summary}\n{details}");
            form.ShowDialog(); // Corrected line
        }
        public class DisplayResultForm : System.Windows.Forms.Form
        {
            public DisplayResultForm(string result)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox
                {
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    Dock = DockStyle.Fill,
                    Text = result
                };

                Controls.Add(textBox);
                Text = "Repeated Numbers Report";
                Size = new System.Drawing.Size(400, 300); // Make sure to specify the full namespace for System.Drawing.Size
            }
        }

        private int GetSearchValue()
        {
            if (int.TryParse(SearchLinearSearchTextBox.Text, out int searchValue))
            {
                return searchValue;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the search value.");
                return int.MinValue;
            }
        }

    }
}

