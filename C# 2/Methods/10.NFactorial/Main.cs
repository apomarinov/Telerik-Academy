using System;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].

class MainClass
{
	public static void Main ()
	{
		BigInteger f = 1;
		for (int i = 1, j; i <= 100; i++) {
			f = j = i;
			while (j > 1) {
				f *= j - 1;
				j--;
			}
			Console.WriteLine (i + " - " + f);
			f = 1;
		}
	}
}

