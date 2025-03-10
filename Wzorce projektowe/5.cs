using System;
using System.Collections.Generic;
using System.Text;

class Program
{
	const int MOD = 1000000007;
	const int MAX_N = 11; // Max value of n as per constraints
	static int[,] gcdTable = new int[MAX_N + 1, MAX_N + 1];

	// Precompute GCD values for small numbers (since max popcount is at most 11)
	static void PrecomputeGCD()
	{
		for (int i = 0; i <= MAX_N; i++)
		{
			for (int j = 0; j <= MAX_N; j++)
			{
				gcdTable[i, j] = GCD(i, j);
			}
		}
	}

	// Compute GCD using Euclidean algorithm
	static int GCD(int a, int b)
	{
		while (b != 0)
		{
			int temp = b;
			b = a % b;
			a = temp;
		}
		return a;
	}

	// Function to compute the population count (number of 1s in binary representation)
	static int Popcount(int x)
	{
		int count = 0;
		while (x > 0)
		{
			count += x & 1;
			x >>= 1;
		}
		return count;
	}

	static long ComputeS(int n)
	{
		int upperLimit = (1 << n); // 2^n
		Dictionary<int, int> freq = new Dictionary<int, int>();

		// Count occurrences of each popcount value
		for (int i = 1; i < upperLimit; i++)
		{
			int count = Popcount(i);
			if (!freq.ContainsKey(count))
				freq[count] = 0;
			freq[count]++;
		}

		// Compute S using frequency distribution
		long S = 0;
		List<int> uniquePopcounts = new List<int>(freq.Keys);

		for (int i = 0; i < uniquePopcounts.Count; i++)
		{
			for (int j = i; j < uniquePopcounts.Count; j++)
			{
				int pop1 = uniquePopcounts[i];
				int pop2 = uniquePopcounts[j];

				int gcdValue = gcdTable[pop1, pop2];

				long pairs = (i == j)
					? ((long)freq[pop1] * (freq[pop1] - 1) / 2) % MOD
					: ((long)freq[pop1] * freq[pop2]) % MOD;

				S = (S + (pairs * gcdValue) % MOD) % MOD;
			}
		}

		return S;
	}

	static void Main()
	{
		PrecomputeGCD(); // Precompute GCD table

		int T;
		if (!int.TryParse(Console.ReadLine(), out T) || T < 1) return; // Handle invalid input

		StringBuilder output = new StringBuilder();

		while (T-- > 0)
		{
			int n;
			if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > MAX_N) continue; // Handle invalid input
			output.AppendLine(ComputeS(n).ToString());
		}

		Console.Write(output.ToString()); // Print all output at once for efficiency
	}
}

