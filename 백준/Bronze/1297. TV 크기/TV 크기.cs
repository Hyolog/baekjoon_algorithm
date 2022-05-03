using System;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();

            var diagonal = int.Parse(input[0]);
            var hRatio = int.Parse(input[1]);
            var wRatio = int.Parse(input[2]);

            var x = diagonal / Math.Pow(Math.Pow(hRatio, 2) + Math.Pow(wRatio, 2), 0.5);

            var h = (int)(x * hRatio);
            var w = (int)(x * wRatio);

            Console.WriteLine($"{h} {w}");
        }
    }
}