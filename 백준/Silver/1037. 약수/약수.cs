using System;
using System.Linq;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();
            var input = Console.ReadLine();

            var factors = input.Split(' ').Select(d => int.Parse(d));
            var minFactor = factors.Min();
            var maxFactor = factors.Max();

            Console.WriteLine(minFactor * maxFactor);
        }
    }
}
