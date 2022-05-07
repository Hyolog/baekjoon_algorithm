using System;
using System.Linq;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            var A = Console.ReadLine().Split(' ').Select(d => int.Parse(d)).OrderBy(d => d).ToArray();
            var B = Console.ReadLine().Split(' ').Select(d => int.Parse(d)).OrderByDescending(d => d).ToArray();

            var min = 0;

            for (int i = 0; i < A.Count(); i++)
                min += A[i] * B[i];

            Console.WriteLine(min);
        }
    }
}