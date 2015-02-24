using System;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

class MainClass
{
	static void Main ()
	{
		Console.WriteLine ("Min:     " + Min (1, 2, 4, 9, 7, 5));
		Console.WriteLine ("Max:     " + Max (1, 2, 4, 9, 7, 5));
		Console.WriteLine ("Average: " + Avg (1, 2, 4, 9, 7, 5).ToString ("F2"));
		Console.WriteLine ("Sum:     " + Sum (1, 2, 4, 9, 7, 5));
		Console.WriteLine ("Product: " + Product (1, 2, 4, 9, 7, 5));
	}
	
	static int Min (params int[] sequence)
	{
		int min = sequence [0];
		for (int i = 0; i < sequence.Length; i++) {
			if (min > sequence [i]) {
				min = sequence [i];
			}
		}
		return min;
	}
	
	static int Max (params int[] sequence)
	{
		int max = sequence [0];
		for (int i = 0; i < sequence.Length; i++) {
			if (max < sequence [i]) {
				max = sequence [i];
			}
		}
		return max;
	}
	
	static double Avg (params int[] sequence)
	{
		double sum = 0;
		for (int i = 0; i < sequence.Length; i++) {
			sum += sequence [i];
		}
		return sum / sequence.Length;
	}
	
	static int Sum (params int[] sequence)
	{
		int sum = 0;
		for (int i = 0; i < sequence.Length; i++) {
			sum += sequence [i];
		}
		return sum;
	}
	
	static int Product (params int[] sequence)
	{
		int product = 1;
		for (int i = 0; i < sequence.Length; i++) {
			product *= sequence [i];
		}
		return product;
	}
}