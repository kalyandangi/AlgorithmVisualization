using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationLibrary.SearchVisualizer
{
    public class OperationLinearSearch: ISearchVisualizer
    {
        
        public List<int> FindSmallestNumberIndices(int[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }

            int smallest = data[0];
            List<int> indices = new List<int> { 0 };

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < smallest)
                {
                    smallest = data[i];
                    indices.Clear(); 
                    indices.Add(i);
                }
                else if (data[i] == smallest)
                {
                    indices.Add(i); 
                }
            }

            return indices;
        }

        public List<int> FindLargestNumberIndices(int[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("The array is empty.");
            }

            int largest = data[0];
            List<int> indices = new List<int> { 0 };

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > largest)
                {
                    largest = data[i];
                    indices.Clear(); 
                    indices.Add(i);
                }
                else if (data[i] == largest)
                {
                    indices.Add(i); 
                }
            }

            return indices;
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

        public int CountTotalUniqueValues(int[] data)
        {
            return data.Distinct().Count();
        }

        public List<int> FindOccurrences(int[] data, int searchValue)
        {
            List<int> occurrences = new List<int>();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == searchValue)
                {
                    occurrences.Add(i);
                }
            }

            return occurrences;
        }
    }
}
