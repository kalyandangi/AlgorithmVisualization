using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace VisualizationLibrary.SearchVisualizer
{
    public class OperationBinarySearch : ISearchVisualizer
    {   
        public int CountTotalUniqueValues(int[] data)
        {
            return data.Distinct().Count();
        }

        
        public List<int> FindLargestNumberIndices(int[] data)
        {
            
            int[] sortedData = new int[data.Length];
            Array.Copy(data, sortedData, data.Length);
            Array.Sort(sortedData);
            int left = 0;
            int right = sortedData.Length - 1;
            int mid;

            List<int> indices = new List<int>();

            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (mid < right && sortedData[mid] > sortedData[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            int maxValue = sortedData[right];
            for(int i = 0; i< data.Length; i++)
            {
                if (data[i] == maxValue)
                {
                    indices.Add(i);
                }
            }
            return indices;

            
        }

        public List<int> FindOccurrences(int[] data, int searchValue)
        {
            List<int> occurrences = new List<int>();
            int[] sortedData = new int[data.Length];
            Array.Copy(data, sortedData, data.Length);
            Array.Sort(sortedData);
            int left = 0;
            int right = sortedData.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (sortedData[mid] == searchValue)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i] == searchValue)
                        {
                            occurrences.Add(i);
                        }
                    }
                    return occurrences; 
                }
                else if (sortedData[mid] < searchValue)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return occurrences; 
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

            foreach (var kvp in numberPositions.Where(pair => pair.Value.Count == 1).ToList())
            {
                numberPositions.Remove(kvp.Key);
            }

            return numberPositions;
        }

        public List<int> FindSmallestNumberIndices(int[] data)
        {
            int[] sortedData = new int[data.Length];
            Array.Copy(data, sortedData, data.Length);
            Array.Sort(sortedData);
            int left = 0;
            int right = sortedData.Length - 1;
            int mid;


            List<int> indices = new List<int>();

            while (left > right)
            {
                mid = left + (right - left) / 2;
                if (sortedData[mid] < sortedData[mid - 1])
                {
                    left = 0;
                }
                else
                {
                    right = mid;
                }
            }
            int minValue = sortedData[left];
          
                for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == minValue)
                {
                    indices.Add(i);
                }
            }
            return indices;
        }
    }
}
