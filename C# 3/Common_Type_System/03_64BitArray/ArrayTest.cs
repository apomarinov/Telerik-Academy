using System;
using Array64Bit;

class ArrayTest
{
	public static void Main ()
	{
		BitArray64 num1 = new BitArray64 ();
		BitArray64 num2 = new BitArray64 ();
		BitArray64 num3 = new BitArray64 ();
		
		num1 [5] = 1;
		num1 [8] = 1;
		num1 [22] = 1;
		
		num2 [5] = 1;
		num2 [8] = 1;
		num2 [22] = 1;
		
		Console.WriteLine ("num1: \n" + num1);
		Console.WriteLine ("num2: \n" + num2);
		Console.WriteLine ("num3: \n" + num3);
		
		Console.WriteLine ("Hash num1: " + num1.GetHashCode ());
		Console.WriteLine ("Hash num2: " + num2.GetHashCode ());
		Console.WriteLine ("Hash num3: " + num3.GetHashCode ());
		
		Console.WriteLine ("num1 == num2: " + (num1 == num2));
		Console.WriteLine ("num1 == num3: " + (num1 == num3));
	}
}