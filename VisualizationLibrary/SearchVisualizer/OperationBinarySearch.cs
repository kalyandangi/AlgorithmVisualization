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
            //int minValue = data[left];
         //   int value = data[mid];
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
            throw new NotImplementedException();
        }

        public Dictionary<int, List<int>> FindRepeatedNumbersAndPositions(int[] data)
        {
            throw new NotImplementedException();
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
                if (data[mid] < data[mid - 1])
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
