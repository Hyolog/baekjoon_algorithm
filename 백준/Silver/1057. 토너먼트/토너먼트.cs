using System;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var countOfPeople = input[0];
            var jimin = int.Parse(input[1]);
            var hansu = int.Parse(input[2]);
            var round = 1;

            while (Math.Abs(jimin - hansu) != 1 || (jimin + hansu + 1) % 4 != 0)
            {
                jimin = (jimin + 1) / 2;
                hansu = (hansu + 1) / 2;
                round++;
            }

            Console.WriteLine(round);
        }
    }
}