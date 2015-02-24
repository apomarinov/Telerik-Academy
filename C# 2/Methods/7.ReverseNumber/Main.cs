using System;

//Write a method that reverses the digits of given decimal number.
//Example:
//	
//input	output
//256	652

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
		Console.WriteLine (ReverseNumber (num));
	}

	static bool ReadInput ()
	{
		Console.Write ("Enter number: ");
		if (!int.TryParse (Console.ReadLine (), out num)) {
			return false;
		}
		
		return true;
	}
	
	static int ReverseNumber (int n)
	{
		bool negative = n < 0;
		n = Math.Abs (n);
		char[] digits = n.ToString ().ToCharArray ();
		string newNum = "";
		
		for (int i = digits.Length - 1; i >= 0; i--) {
			newNum += digits [i];
		}
		
		return int.Parse (newNum) * (negative ? -1 : 1);
	}
}