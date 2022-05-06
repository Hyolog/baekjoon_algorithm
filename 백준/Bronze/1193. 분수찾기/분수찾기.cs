using System;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var sum = 0;
            var row = 0;

            while (sum < number)
            {
                row++;
                sum = row * (row + 1) / 2;
            }

            sum = row * (row - 1) / 2;
            var index = number - sum - 1;
            var result = row % 2 == 1 ? $"{row - index}/{1 + index}" : $"{1 + index}/{row - index}";

            Console.WriteLine(result);
        }
    }
}
