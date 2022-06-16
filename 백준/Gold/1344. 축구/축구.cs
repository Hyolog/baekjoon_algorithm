using System;

namespace baekjoon_algorithm
{
    class Program
    {
		static double[,,] dp = new double[20, 20, 20];

        static void Main()
        {
			var a = double.Parse(Console.ReadLine()) / 100;
			var b = double.Parse(Console.ReadLine()) / 100;

			dp[0, 0, 0] = 1.0;

			for (int i = 1; i <= 18; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					for (int k = 0; k <= i; k++)
					{
						if (j > 0) 
							dp[i, j, k] += dp[i - 1, j - 1, k] * a * (1 - b);
						if (k > 0) 
							dp[i, j, k] += dp[i - 1, j, k - 1] * (1 - a) * b;
						if (j > 0 && k > 0) 
							dp[i, j, k] += dp[i - 1, j - 1, k - 1] * a * b;
						
						dp[i, j, k] += dp[i - 1, j, k] * (1 - a) * (1 - b);
					}
				}
			}

			double result = 0;

			for (int i = 0; i <= 18; i++)
				for (int j = 0; j <= 18; j++)
					if (IsPrimenNumber(i) || IsPrimenNumber(j)) 
						result += dp[18, i, j];

			Console.WriteLine(result);
		}

        private static bool IsPrimenNumber(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}