using System;
using System.Collections.Generic;
using System.Linq;

namespace baekjoon_algorithm
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine();

            var people = Console.ReadLine().Split(' ').Select(d => int.Parse(d)).ToArray();

            var result = new List<int>();

            while (result.Count != people.Count())
            {
                var IndexOfNextPerson = Array.IndexOf(people, 0);

                for (var i = 0; i < IndexOfNextPerson; i++)
                    people[i]--;

                people[IndexOfNextPerson] = -1;

                result.Add(IndexOfNextPerson + 1);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}