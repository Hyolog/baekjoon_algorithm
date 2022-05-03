using System;
using System.IO;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            //var input = Console.ReadLine().Split();
            var input = File.ReadAllText(@"../../../input.txt");

            File.WriteAllText(@"../../../output.txt", $""); 
            //Console.WriteLine($"{h} {w}");
        }
    }
}
