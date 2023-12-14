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
            // Initialize the Graph property using the GenerateGraph method
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

        public List<int> BreadthFirstSearch()
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

            foreach (var kvp in Graph)
            {
                int node = kvp.Key;
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

            foreach (var node in BreadthFirstSearch()) // Assuming starting from node 0
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

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == searchValue)
                {
                    occurrences.Add(i);
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

            // Exclude numbers that appear only once
            foreach (var kvp in numberPositions.Where(pair => pair.Value.Count == 1).ToList())
            {
                numberPositions.Remove(kvp.Key);
            }

            return numberPositions;
        }
    }
}
