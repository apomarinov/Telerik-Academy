using System;
using Microsoft.CSharp.RuntimeBinder;
using CustomGenerics;

class GenericMatrixTest
{
	public static void Main ()
	{
		Matrix<int> m1 = new Matrix<int> (3, 2);
		m1 [0, 0] = 1;
		m1 [0, 1] = 2;
		m1 [1, 0] = 3;
		m1 [1, 1] = 4;
		m1 [2, 0] = 5;
		m1 [2, 1] = 6;
		
		Matrix<int> m2 = new Matrix<int> (3, 2);
		m2 [0, 0] = 1;
		m2 [0, 1] = 2;
		m2 [1, 0] = 3;
		m2 [1, 1] = 4;
		m2 [2, 0] = 5;
		m2 [2, 1] = 6;
		
		Matrix<int> m3 = new Matrix<int> (2, 3);
		m3 [0, 0] = 1;
		m3 [0, 1] = 2;
		m3 [0, 2] = 3;
		m3 [1, 0] = 4;
		m3 [1, 1] = 5;
		m3 [1, 2] = 6;
		
		Console.WriteLine ("Matrix 1:");
		Console.WriteLine (m1.ToString ());
		Console.WriteLine ("Matrix 2:");
		Console.WriteLine (m2.ToString ());
		Console.WriteLine ("Matrix 3:");
		Console.WriteLine (m3.ToString ());
		
		Console.WriteLine ("m1 * m2 = ");
		Console.WriteLine ((m1 * m3).ToString());
	}
}