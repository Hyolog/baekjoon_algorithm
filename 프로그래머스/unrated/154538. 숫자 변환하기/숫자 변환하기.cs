using System;

public class Solution {
    private int MAX = int.MaxValue;

    public int solution(int x, int y, int n)
    {
        int[] dp = new int[y + 1];

        for (var i = x + 1; i < y + 1; i++)
        {
            int a = MAX, b = MAX, c = MAX, d;

            if (CanDivid(i, 2) && (x <= i / 2)) a = dp[i / 2];
            if (CanDivid(i, 3) && (x <= i / 3)) b = dp[i / 3];
            if ((x <= i - n)) c = dp[i - n];

            d = Math.Min(a, b);
            d = Math.Min(d, c);

            dp[i] = d < MAX ? d + 1 : MAX;
        }

        return dp[y] < MAX ? dp[y] : -1;
    }

    private static bool CanDivid(int num, int divide)
    {
        return num % divide == 0;
    }
}