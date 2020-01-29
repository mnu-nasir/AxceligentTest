using System;
using System.Collections;

namespace _1_SumOfBiggestNeighbor
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //int[] input = { 1, 2, 1, 5, 5, 3, 3, 3, 4 };
            int[] input = { 1, 6, 1, 2, 6, 1, 6, 6 };            

            if (input.Length < 2)
            {
                Console.WriteLine("Array should contain more than 1 integer value.");
                Console.ReadKey();

                return;
            }

            var program = new Program();
            Console.WriteLine($"Result : {program.Challenge(input)}");

            Console.ReadKey();
        }

        public int Challenge(int[] input)
        {
            ArrayList arrList = new ArrayList();

            for (int i = 0; i < input.Length; i++)
            {
                if (arrList.Contains(input[i]))
                    continue;

                int count = CountInArray(input, input[i]);

                if (count > 1)
                {
                    for (int j = 0; j < count; j++)
                    {
                        arrList.Add(input[i]);
                    }
                }
            }

            // Sorting the array in ascending order
            arrList.Sort();

            // If input array doesn't have repeating value
            if (arrList.Count == 0)
                return 0;

            // After sorting the biggest element will be at the last  index
            int result = int.Parse(arrList[arrList.Count - 1].ToString());

            return result * 2; // 
        }

        public int CountInArray(int[] array, int num)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                    ++count;
            }

            return count;
        }
    }
}
