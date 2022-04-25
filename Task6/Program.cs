using System;
using System.Collections;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetSquares(1, 2, 3, 4, 5, 6, 7, 8, 9))
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable GetSquares(params int[] input)
        {
            foreach (var item in input)
            {
                if (item % 2 != 0)
                    yield return item * item;
            }
            yield break;
        }
    }
}
