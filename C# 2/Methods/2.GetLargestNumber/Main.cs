using System;

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class MainClass
{
	static int num1, num2, num3;
	
	public static void Main ()
	{
		if (!ReadInput ()) {
			Console.WriteLine ("Invalid Input bro");
			return;
		}
		PrintOutput ();
	}

	static void PrintOutput ()
	{
		int max1 = GetMax (num1, num2);
		int max2 = GetMax (max1, num3);
		int max3 = GetMax (max1, max2);
		Console.WriteLine (max3);
	}

	static bool ReadInput ()
	{
		Console.Write ("Enter number 1: ");
		if (!int.TryParse (Console.ReadLine (), out num1)) {
			return false;
		}
		
		Console.Write ("Enter number 2: ");
		if (!int.TryParse (Console.ReadLine (), out num2)) {
			return false;
		}
		
		Console.Write ("Enter number 3: ");
		if (!int.TryParse (Console.ReadLine (), out num3)) {
			return false;
		}
		
		return true;
	}
	
	static int GetMax (int a, int b)
	{
		return a > b ? a : b;
	}
}