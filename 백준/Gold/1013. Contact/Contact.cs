using System;
using System.Text.RegularExpressions;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            var countOfWave = Console.ReadLine();

            for (int i = 0; i < int.Parse(countOfWave); i++)
                Console.WriteLine(IsValidPattern(Console.ReadLine()) ? "YES" : "NO");
        }

        private static bool IsValidPattern(string wave)
        {
            return new Regex(@"^(100+1+|01)+$").IsMatch(wave);
        }
    }
}