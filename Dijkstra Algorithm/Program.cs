using System.Collections;  // for ArrayList data type

namespace Dijkstra_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NEED AN UNDIRECTED GRAPH WITH WEIGHTS FOR INPUT

            Console.WriteLine($"-------------------- Initializations --------------------\n");

            ArrayList distance = new ArrayList() { 0, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };  // there are 5 nodes (A-E), so there are 5 distances
            PrintDistArr(distance);

            ArrayList unvisitedNodes = new ArrayList() { 'A', 'B', 'C', 'D', 'E' };  // all nodes in the graph; this array will be empty when the algorithm completes
            PrintUnvisitedArr(unvisitedNodes);

            ArrayList visitedNodes = new ArrayList() { };  // this array will contain all 5 nodes when the algorithm completes
            PrintVisitedArr(visitedNodes);
            
            // ----------------------------- Dijkstra's Algorithm -----------------------------

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
                // I DON'T KNOW HOW TO INPUT AN UNDIRECTED GRAPH WITH WEIGHTS AND ACCESS NEIGHBORS

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