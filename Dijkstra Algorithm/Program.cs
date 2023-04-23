namespace Dijkstra_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] distance = { 0, int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue };
            PrintDistArr(distance);

            char[] unvisitedNodes = { 'A', 'B', 'C', 'D', 'E' };
            PrintUnvisitedArr(unvisitedNodes);

            char[] visitedNodes = new char[unvisitedNodes.Length];
            PrintVisitedArr(visitedNodes);

            while (unvisitedNodes != null)  // keep iterating
            {
                int count = 1;
                Console.WriteLine($"---------- Iteration Number {count} ----------");
                break;


            }

        }

        public static void PrintDistArr(int[] array)
        {
            Console.WriteLine("Distance array contains:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintUnvisitedArr(char[] array)
        {
            Console.WriteLine("Unvisited nodes array contains:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintVisitedArr(char[] array)
        {
            Console.WriteLine("Visited nodes array contains:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine("\n");
        }
    }
}