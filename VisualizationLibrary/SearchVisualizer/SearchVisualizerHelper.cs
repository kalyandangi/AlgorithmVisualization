using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace VisualizationLibrary.SearchVisualizer
{
    public static class SearchVisualizerHelper
    {
        public static event EventHandler<DisplayDataEventArgs> DisplayDataRequested;

        public static void DisplaySearchResult(List<int> data, string message, List<int> positions)
        {
            if (positions.Count > 0)
            {
                string positionsStr = string.Join(", ", positions);
                string resultMessage = $"{message}: {data[positions[0]]}\nPosition(s): {positionsStr}";
                MessageBox.Show(resultMessage, "Search Result");
            }
            else
            {
                MessageBox.Show("Search value not found.");
            }
        }

        public static void DisplayRepeatedNumberResult(List<int> data, Dictionary<int, List<int>> repeatedNumberPositions)
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

            MessageBox.Show($"{summary}\n{details}", "Repeated Numbers Report");
        }


        public static int GetSearchValue(string searchText)
        {
            if (int.TryParse(searchText, out int searchValue))
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

    public class DisplayDataEventArgs : EventArgs
    {
        public int[] Data { get; }
        public string DisplayText { get; }

        public DisplayDataEventArgs(int[] data, string displayText)
        {
            Data = data;
            DisplayText = displayText;
        }
    }
}
