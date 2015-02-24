using System;
using System.Collections.Generic;
using System.Linq;

//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

class MainClass
{
	static string num1 = "123";
	static string num2 = "123";
	
	public static void Main ()
	{
		// set to false to manually enter input
		bool simulateInput = true;
		if (simulateInput) {
			PrintOutput ();
			return;
		}

		if (!ReadInput ()) {
			Console.WriteLine ("Invalid Input bro");
			return;
		}
		PrintOutput ();
	}

	static void PrintOutput ()
	{
		Console.WriteLine (AddNumberArrays (num1, num2));
	}

	static bool ReadInput ()
	{
		int testNum;
		Console.WriteLine ("Enter number 1: ");
		num1 = Console.ReadLine ();
		if (!int.TryParse (num1, out testNum)) {
			return false;
		}
		
		Console.WriteLine ("Enter number 2: ");
		num2 = Console.ReadLine ();
		if (!int.TryParse (num1, out testNum)) {
			return false;
		}
		
		return true;
	}
	
	static int AddNumberArrays (string first, string second)
	{
		int[] a = first.Select (ch => ch - '0').ToArray ();
		int[] b = second.Select (ch => ch - '0').ToArray ();		
		List<int> result = new List<int> (Math.Max (a.Length, b.Length));
		Array.Reverse (a);
		Array.Reverse (b);
		
		int firstDigit = 0;
		
		for (int i = 0; i < result.Capacity; i++) {
			int num = (i < a.Length ? a [i] : 0) + (i < b.Length ? b [i] : 0) + firstDigit;
			firstDigit = num / 10;
			result.Add (num % 10);
		}
		
		if (firstDigit > 0)
			result.Add (firstDigit);
		
		int[] numArr = new int[result.Count];
		numArr = result.ToArray ();
		Array.Reverse (numArr);
		string numAsStr = string.Join ("", numArr.Select (v => v.ToString ()));
		return int.Parse (numAsStr);
	}
}