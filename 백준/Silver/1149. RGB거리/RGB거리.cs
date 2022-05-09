using System;
using System.Linq;

namespace baekjoon_algorithm
{
    class Program
    {
        static int n;
        static int[,] cost;
        // 4.[메모(기록)하기]
        static int[,] accumulatedCost;

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            
            cost = new int[n, 3];
            accumulatedCost = new int[n, 3];

            // 2.[문제의 변수] : houseIndex(houseIndex번째 까지의 비용 합이 최소가 되는 값을 구해야 하므로)
            for (var houseIndex = 0; houseIndex < n; houseIndex++)
            {
                var costs = Console.ReadLine().Split(' ').Select(d => int.Parse(d)).ToArray();

                cost[houseIndex, 0] = costs[0];
                cost[houseIndex, 1] = costs[1];
                cost[houseIndex, 2] = costs[2];

                // 6.[구현] Bottom-up (loop 사용)
                SumMinCost(houseIndex);
            }

            Console.WriteLine(Math.Min(accumulatedCost[n - 1, 0], Math.Min(accumulatedCost[n - 1, 1], accumulatedCost[n - 1, 2])));
        }

        static void SumMinCost(int houseIndex)
        {
            // 5.[기저상태 파악]
            if (houseIndex == 0)
            {
                accumulatedCost[houseIndex, 0] = cost[houseIndex, 0];
                accumulatedCost[houseIndex, 1] = cost[houseIndex, 1];
                accumulatedCost[houseIndex, 2] = cost[houseIndex, 2];
            }
            else
            {
                // 1.[DP문제인지 파악] - Overlapping Subproblems 조건 : 만족(houseIndex번째 문제를 (houseIndex - 1)번째 문제를 이용해 풀 수 있다)
                // 1.[DP문제인지 파악] - Optimal Substructure 조건 : 만족((houseIndex - 1)까지 최적해와 houseIndex의 최소값으로 houseIndex 최적해를 구할 수 있다)
                // 3.[점화식] - F(i) = F(i-1) + D(i)
                accumulatedCost[houseIndex, 0] = Math.Min(accumulatedCost[houseIndex - 1, 1], accumulatedCost[houseIndex - 1, 2]) + cost[houseIndex, 0];
                accumulatedCost[houseIndex, 1] = Math.Min(accumulatedCost[houseIndex - 1, 0], accumulatedCost[houseIndex - 1, 2]) + cost[houseIndex, 1];
                accumulatedCost[houseIndex, 2] = Math.Min(accumulatedCost[houseIndex - 1, 0], accumulatedCost[houseIndex - 1, 1]) + cost[houseIndex, 2];
            }
        }
    }
}