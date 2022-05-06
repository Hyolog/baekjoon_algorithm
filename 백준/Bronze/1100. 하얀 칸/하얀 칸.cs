using System;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            var countOfWhitePieces = 0;

            for (int row = 0; row < 8; row++)
            {
                var line = Console.ReadLine();

                for (int column = 0; column < 8; column += 2)
                {
                    var gap = row % 2;
                    var val = line[column + gap];

                    if (val.Equals('F'))
                        countOfWhitePieces++;
                }
            }

            Console.WriteLine(countOfWhitePieces);
        }
    }
}
