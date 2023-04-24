using System.Collections;  // for ArrayList data type

namespace Dijkstra_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input for algorithm: an undirected graph with weights
            // Using an adjacency matrix to represent the graph
            // int[,] is a 2-D array that represents a matrix of rows and columns

            int[,] adjacencyMatrix =
           // col 0   1  2  3  4
            {  // A   B  C  D  E
                { 0, 10, 3, 0, 0},   // A  row 0
				{ 10, 0, 4, 2, 0},   // B  row 1
                { 3, 4, 0, 8, 2},    // C  row 2
                { 0, 2, 8, 0, 9},    // D  row 3
                { 0, 0, 2, 9, 0},    // E  row 4
            };

            /* playing with matrix
            
            Console.WriteLine(adjacencyMatrix[2, 0]);  // [row][col]
            adjacencyMatrix[2, 0] = 111;
            Console.WriteLine(adjacencyMatrix[2, 0]);  // [row][col]

            // printing matrix
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)  // 0 is for the first dimension (rows) 
            {
                for (int j = 0; j < adjacencyMatrix.GetLength(1); j++)  // 1 is for the second dimension (columns)
                {
                    Console.Write(adjacencyMatrix[i, j] + "  ");
                }
                Console.WriteLine();
            }
            */

            Console.WriteLine($"-------------------- Initializations --------------------\n");

            ArrayList distance = new ArrayList() { 0, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };  // there are 5 nodes (A-E), so there are 5 distances
            PrintDistArr(distance);

            ArrayList unvisitedNodes = new ArrayList() { 'A', 'B', 'C', 'D', 'E' };  // all nodes in the graph; this array will be empty when the algorithm completes
            PrintUnvisitedArr(unvisitedNodes);

            ArrayList visitedNodes = new ArrayList() { };  // this array will contain all 5 nodes when the algorithm completes
            PrintVisitedArr(visitedNodes);
            
            int count = 1;  // to count the number of iterations performed
            
            while (unvisitedNodes.Count > 0)  // keep iterating while the unvisitedNodes array isn't empty
            {
                // visit the unvisited node with the smallest value in the distance array
                // THIS SHOULD BE THE 1ST POSITION IN THE unvisitedNode array AFTER I GET HELP WITH THIS
                // (in the 1st iteration, start with source node A; its corresponding value in the distance array is already the smallest)

                // add the first node from unvisitedNodes to visitedNodes
                visitedNodes.Add(unvisitedNodes[0]);

                // remove it from unvisitedNodes
                unvisitedNodes.Remove(unvisitedNodes[0]);

                // for each of the node's neighbors, update the distance array
                // I DON'T KNOW HOW TO ACCESS THE NEIGHBORS HERE

                // to compare distance values
                int priorDistance = distance[INDEX OF NEIGHBOR];  // NEED HELP HERE
                int newDistance = distance[0] + distance[INDEX OF NEIGHBOR];  // NEED HELP HERE

                // if the new distance is smaller than the prior distance, update the distance array with the smaller value
                if (newDistance < priorDistance)
                    distance[0] = newDistance;

                // sort the unvisitedNodes array so the node with the smallest corresponding distance in the distance array is first
                // I DON'T KNOW HOW TO CODE THIS
                // I can use .Sort() on a copy of the distance array to get the smallest distance first, but
                // this doesn't sort the unvisitedNodes array from smallest to largest based on it's corresponding values in the distance array

                Console.WriteLine($"-------------------- End of Iteration Number {count} --------------------\n");
                Console.WriteLine($"RESULTS FROM ITERATION {count}: \n");
                PrintDistArr(distance);
                PrintUnvisitedArr(unvisitedNodes);
                PrintVisitedArr(visitedNodes);

                count++;  // to increase the iteration count
                break;  // REMOVE WHEN DONE CODING
            }

            Console.WriteLine($"-------------------- Algorithm Completed --------------------\n");

            Console.WriteLine("The shortest path to each node from the source node is: ");
            PrintDistArr(distance);
        }


        // helper functions to print the array values:

        public static void PrintDistArr(ArrayList array)
        {
            Console.WriteLine("Distance array contains:");
            PrintArrList(array);
        }

        public static void PrintUnvisitedArr(ArrayList array)
        {
            Console.WriteLine("Unvisited node array contains:");
            PrintArrList(array);
        }

        public static void PrintVisitedArr(ArrayList array)
        {
            Console.WriteLine("Visited node array contains:");
            PrintArrList(array);
        }

        public static void PrintArrList(ArrayList array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine("\n");
        }
    }
}