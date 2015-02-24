using System;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

class MainClass
{
	static int menuChoice = -1;
	static int num;
	static int[] arr;
	static double a, b;
	
	public static void Main ()
	{
		while (true) {
			if (!ReadInput ()) {
				Console.Write ("Invalid Input bro");
				return;
			}
			
			SolveTask ();
			
			Console.Write ("\nAgain? y/n: ");
			if (Console.ReadLine () == "n") {
				break;
			}
		}
	}
	
	static bool ReadInput ()
	{
		GetUserChoice ();
		
		switch (menuChoice) {
		case 1:
			Console.Write ("Enter number: ");
			if (!int.TryParse (Console.ReadLine (), out num) || num < 0) {
				return false;
			}
			break;
		case 2:
			int size;
			Console.Write ("Enter array size: ");
			if (!int.TryParse (Console.ReadLine (), out size) || size <= 0) {
				return false;
			}
			
			arr = new int[size];
			Console.WriteLine ("Enter array elements: ");
			for (int i = 0; i < size; i++) {
				if (!int.TryParse (Console.ReadLine (), out arr [i])) {
					return false;
				}			
			}
			break;
		case 3:
			Console.Write ("Enter a: ");
			if (!double.TryParse (Console.ReadLine (), out a) || a < 0) {
				return false;
			}
			Console.Write ("Enter b: ");
			if (!double.TryParse (Console.ReadLine (), out b)) {
				return false;
			}
			break;
		}
		
		return true;
	}

	static void GetUserChoice ()
	{
		bool validChoice = false;
		
		while (!validChoice) {
			PrintMenu ();
			validChoice = int.TryParse (Console.ReadLine (), out menuChoice) && menuChoice >= 1 && menuChoice <= 3;
		}
	}
	
	static void PrintMenu ()
	{
		Console.WriteLine ("\nSelect your choice");
		Console.WriteLine ("1. Reverse number digits.");
		Console.WriteLine ("2. Average of array of numbers.");
		Console.WriteLine ("3. Linear Equation: a * x + b = 0.");
	}
	
	static void SolveTask ()
	{
		switch (menuChoice) {
		case 1:
			Console.WriteLine ("Reversed number: " + ReverseNumber ());
			break;
		case 2:
			Console.WriteLine ("Average: " + Average ());
			break;
		case 3:
			Console.WriteLine ("{0} * x + {1} = 0", a, b);
			Console.WriteLine ("x = {0} / {1}", -b, a);
			Console.WriteLine ("x = {0:F2}", -b / a);
			break;
		}
	}
	
	static int ReverseNumber ()
	{
		char[] digits = num.ToString ().ToCharArray ();
		string newNum = "";
		
		for (int i = digits.Length - 1; i >= 0; i--) {
			newNum += digits [i];
		}
		
		return int.Parse (newNum);
	}
	
	static double Average ()
	{
		double sum = 0;
		
		for (int i = 0; i < arr.Length; i++) {
			sum += arr [i];
		}
		
		return sum / arr.Length;
	}
}	







