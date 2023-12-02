using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;

namespace VisualizationLibrary.SearchVisualizer
{
    public interface ISearchVisualizer
    {
        List<int> FindSmallestNumberIndices(int[] data);
        List<int> FindLargestNumberIndices(int[] data);
        Dictionary<int, List<int>> FindRepeatedNumbersAndPositions(int[] data);
        int CountTotalUniqueValues(int[] data);
        List<int> FindOccurrences(int[] data, int searchValue);
    }

}

