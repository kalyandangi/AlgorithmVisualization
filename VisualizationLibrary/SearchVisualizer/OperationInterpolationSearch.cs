using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationLibrary.SearchVisualizer
{
    public class OperationInterpolationSearch : ISearchVisualizer
    {
        public int CountTotalUniqueValues(int[] data)
        {
            return data.Distinct().Count();
        }

        public List<int> FindLargestNumberIndices(int[] data)
        {
            List<int> indices = new List<int>();

            if (data == null || data.Length == 0)
            {
                // Return an empty list if the array is null or empty.
                return indices;
            }

            int maxValue = data.Max();

            // Perform interpolation search to find the largest value.
            int index = InterpolationSearch(data, maxValue);

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == maxValue)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        private static int InterpolationSearch(int[] data, int target)
        {
            int[] sortedData = new int[data.Length];
            Array.Copy(data, sortedData, data.Length);
            Array.Sort(sortedData);
            int low = 0;
            int high = sortedData.Length - 1;

            while (low <= high && target >= sortedData[low] && target <= sortedData[high])
            {
                // Interpolation formula
                int pos = low + ((target - sortedData[low]) * (high - low) / (sortedData[high] - sortedData[low]));

                if (sortedData[pos] == target)
                    return pos;

                if (sortedData[pos] < target)
                    low = pos + 1;
                else
                    high = pos - 1;
            }

            return -1; // Not found
        }
        public List<int> FindOccurrences(int[] data, int searchValue)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, List<int>> FindRepeatedNumbersAndPositions(int[] data)
        {
            Dictionary<int, List<int>> numberPositions = new Dictionary<int, List<int>>();

            for (int i = 0; i < data.Length; i++)
            {
                int currentNumber = data[i];

                if (numberPositions.ContainsKey(currentNumber))
                {
                    numberPositions[currentNumber].Add(i);
                }
                else
                {
                    numberPositions[currentNumber] = new List<int> { i };
                }
            }

            // Exclude numbers that appear only once
            foreach (var kvp in numberPositions.Where(pair => pair.Value.Count == 1).ToList())
            {
                numberPositions.Remove(kvp.Key);
            }

            return numberPositions;
        }

        public List<int> FindSmallestNumberIndices(int[] data)
        {
            List<int> indices = new List<int>();

            if (data == null || data.Length == 0)
            {
                // Return an empty list if the array is null or empty.
                return indices;
            }

            int minValue = data.Min();

            // Perform interpolation search to find the largest value.
            int index = InterpolationSearch(data, minValue);

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == minValue)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }

        public List<int> FindOccurances(int[] data, int searchValue)
        {
            List<int> occurances = new List<int>();
            int[] sortedData = new int[data.Length];
            Array.Copy(data, sortedData, data.Length);
            Array.Sort (sortedData);
            int index = InterpolationSearch(data, searchValue);

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == searchValue)
                {
                    occurances.Add (i);
                }

            }
            return occurances;
        }
    }
}
