using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationLibrary.SearchVisualizer
{
    public class OperationBreadthFirstSearch : ISearchVisualizer
    {
        public Dictionary<int, List<int>> Graph { get; }

        public OperationBreadthFirstSearch(int[] data)
        {
            Graph = GenerateGraph(data);
        }

            private Dictionary<int, List<int>> GenerateGraph(int[] data)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            for (int i = 0; i < data.Length; i++)
            {
                int node = data[i];

                if (!graph.ContainsKey(node))
                {
                    graph[node] = new List<int>();
                }

                if (i < data.Length - 1)
                {
                    int nextNode = data[i + 1];
                    graph[node].Add(nextNode);
                }
            }

            return graph;
        }

        private IEnumerable<int> BreadthFirstSearch()
        {
            List<int> visited = new List<int>();
            Queue<int> queue = new Queue<int>();

            int startNode = Graph.Keys.FirstOrDefault();

            if (!Graph.ContainsKey(startNode))
            {
                throw new ArgumentException($"Starting node {startNode} is not present in the graph.");
            }

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();

                foreach (var neighbor in Graph[currentNode])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return visited;
        }


        public int CountTotalUniqueValues(int[] data)
        {
            return data.Distinct().Count();
        }


        public List<int> FindLargestNumberIndices(int[] data)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Array is null or empty");
            }

            List<int> indices = new List<int>();
            int largest = int.MinValue;

            foreach (var node in BreadthFirstSearch()) 
            {
                int number = data[node];

                if (number > largest)
                {
                    largest = number;
                    indices.Clear();
                    indices.Add(node);
                }
                else if (number == largest)
                {
                    indices.Add(node);
                }
            }

            return indices;
        }

        public List<int> FindSmallestNumberIndices(int[] data)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Array is null or empty");
            }

            List<int> indices = new List<int>();
            int smallest = int.MaxValue;

            foreach (var node in BreadthFirstSearch()) 
            {
                int number = data[node];

                if (number < smallest)
                {
                    smallest = number;
                    indices.Clear();
                    indices.Add(node);
                }
                else if (number == smallest)
                {
                    indices.Add(node);
                }
            }

            return indices;
        }

        public List<int> FindOccurrences(int[] data, int searchValue)
        {
            List<int> occurrences = new List<int>();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == searchValue)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                int currentIndex = queue.Dequeue();
                occurrences.Add(currentIndex);

                int leftIndex = currentIndex - 1;
                while (leftIndex >= 0 && data[leftIndex] == searchValue)
                {
                    queue.Enqueue(leftIndex);
                    leftIndex--;
                }

                int rightIndex = currentIndex + 1;
                while (rightIndex < data.Length && data[rightIndex] == searchValue)
                {
                    queue.Enqueue(rightIndex);
                    rightIndex++;
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
    }
}
