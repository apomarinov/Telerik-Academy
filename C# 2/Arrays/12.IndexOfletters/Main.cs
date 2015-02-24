using System;
using ArrayTools;

// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

class MainClass
{
	static char[] alphabet = new char[26];
	static string word = "word";
	
	public static void Main ()
	{
		GenerateAlphabetArray ();
		// set to false to manually enter input
		bool simulateInput = true;
		if (simulateInput) {
			PrintOutput ();
			return;
		}

		if (!ReadInput ()) {
			Console.Write ("Invalid Input bro");
			return;
		}
		PrintOutput ();
	}

	static void PrintOutput ()
	{
		Console.WriteLine (IndexOfLetters (word.ToUpper ().ToCharArray ()));
	}

	static bool ReadInput ()
	{
		Console.Write ("Enter a word: ");
		word = Console.ReadLine ();

		return true;
	}
	
	static void GenerateAlphabetArray ()
	{
		for (int i = 0; i <= 25; i++) {
			alphabet [i] = (char)(i + 65);
		}
	}
	
	static string IndexOfLetters (char[] wordAsCharArr)
	{
		string result = "";
		
		for (int i = 0; i < wordAsCharArr.Length; i++) {
			result += wordAsCharArr [i] + " > " + Array.IndexOf (alphabet, wordAsCharArr [i]) + ", ";
		}
		
		return result;
	}
}	







