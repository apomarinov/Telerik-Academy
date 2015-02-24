using System;

// Write a program that reads two integer arrays from the console and compares them element by element.

class MainClass
{
	static int[] arr1, arr2;
	static bool simulateInput;

	public static void Main ()
	{
		// set to false to manually enter input
		simulateInput = true;

		if (simulateInput) {
			ExampleInput ();
			return;
		}

		if (!ReadInput ()) {
			Console.Write ("Invalid Input bro");
			return;
		}
		Console.WriteLine ("Equal: " + CompareIntArrays (arr1, arr2));
	}

	static void ExampleInput ()
	{
		arr1 = new int[2];
		arr2 = new int[2];

		arr1 [0] = 1;
		arr1 [1] = 2;

		arr2 [0] = 1;
		arr2 [1] = 2;
		Console.WriteLine ("Equal: " + CompareIntArrays (arr1, arr2));

		arr1 [0] = 1;
		arr1 [1] = 1;

		arr2 [0] = 1;
		arr2 [1] = 2;
		Console.WriteLine ("Equal: " + CompareIntArrays (arr1, arr2));
	}

	static bool ReadInput ()
	{
		int size;

		Console.Write ("Enter array size: ");
		if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
			return false;
		}

		arr1 = new int[size];
		arr2 = new int[size];

		Console.WriteLine ("Enter first array: ");
		for (int i = 0; i < size; i++) {
			if (!int.TryParse (Console.ReadLine (), out arr1 [i])) {
				return false;
			}
		}

		Console.WriteLine ("Enter second array: ");
		for (int i = 0; i < size; i++) {
			if (!int.TryParse (Console.ReadLine (), out arr2 [i])) {
				return false;
			}
		}

		return true;
	}

	static bool CompareIntArrays (int[] arrOne, int[] arrTwo)
	{
		int length = arrOne.Length;

		if (length != arrTwo.Length) {
			return false;
		}

		for (int i = 0; i < length; i++) {
			if (arrOne [i] != arrTwo [i]) {
				return false;
			}
		}

		return true;
	}
}