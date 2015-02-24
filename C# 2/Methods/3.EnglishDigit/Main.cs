using System;

//Write a method that returns the last digit of given integer as an English word.
//Examples:
//	
//input	output
//512		two
//1024	four
//12309	nine
		
class MainClass
{
	static int num;
	
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
		Console.WriteLine (DigitAsWord (num));
	}

	static bool ReadInput ()
	{
		Console.Write ("Enter number: ");
		if (!int.TryParse (Console.ReadLine (), out num)) {
			return false;
		}
		
		return true;
	}
	
	static string DigitAsWord (int n)
	{
		switch (n % 10) {
		case 0:
			return "zero";
		case 1:
			return "one";
		case 2: 
			return "two";
		case 3:
			return "three";
		case 4:
			return "four";
		case 5:
			return "five";
		case 6:
			return "six";
		case 7:
			return "seven";
		case 8:
			return "eight";
		case 9:
			return "nine";
		default:
			return "invalid";
		}
	}
}









