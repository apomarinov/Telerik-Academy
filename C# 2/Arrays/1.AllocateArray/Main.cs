using System;
using ArrayTools;
// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Print the obtained array on the console.

class MainClass
{
	public static void Main ()
	{
		int size = 20, multiplier = 5;

		var intArray = ArrayElementsAsIndexMultipliedBy (size, multiplier);

		// for this homework I decided to try out a static class, so you will find the logic
		// for ArrayTo.String in the ArrayTools.cs file in the solution
		// which I created to collect functionality that I used in more than one project
		// and just added a link to each project I need it into
		// this way each project is more clear, and I can use same functionality without duplicating code
		Console.WriteLine (ArrayTo.String (intArray));
	}

	static int[] ArrayElementsAsIndexMultipliedBy (int size, int multiplier)
	{
		var arr = new int[size];
		
		for (int i = 0; i < size; i++) {
			arr [i] = i * multiplier;
		}
		
		return arr;
	}
}
