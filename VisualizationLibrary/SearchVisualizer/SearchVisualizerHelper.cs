using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;

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
            DisplayDataEventArgs displayEventArgs = new DisplayDataEventArgs(data.ToArray(), "Repeated Numbers Report", repeatedNumberPositions);
            DisplayDataRequested?.Invoke(null, displayEventArgs);
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
        public Dictionary<int, List<int>> RepeatedNumberPositions { get; }

        public DisplayDataEventArgs(int[] data, string displayText, Dictionary<int, List<int>> repeatedNumberPositions)
        {
            Data = data;
            DisplayText = displayText;
            RepeatedNumberPositions = repeatedNumberPositions;
        }
    }
}