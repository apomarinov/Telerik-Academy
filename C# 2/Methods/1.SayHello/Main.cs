using System;

//Write a method that asks the user for his name and prints “Hello, <name>”
//	Write a program to test this method.
//Example:
//
//input	output
//Peter	Hello, Peter!

class MainClass
{
	public static void Main ()
	{
		Console.Write ("Enter name: ");
		string input = Console.ReadLine ();
		SayHello (input);
	}
	
	static void SayHello (string name)
	{
		Console.WriteLine ("Hello " + name + "!");
	}
}