using System;

// 11
//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:	
//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

// 12
//Extend the previous program to support also subtraction and multiplication of polynomials.

class MainClass
{
	static decimal[] first = { 4, -2};
	static decimal[] second = { 8, -5, 2};
	
	public static void Main ()
	{
		PrintOutput ();
	}
	
	static void PrintOutput ()
	{
		Console.WriteLine ("First:          " + ToString (first));
		Console.WriteLine ("Second:         " + ToString (second));
		Console.WriteLine ();
		Console.WriteLine ("Sum:            " + ToString (PolynomialOperation (first, second)));
		Console.WriteLine ("Difference:     " + ToString (PolynomialOperation (first, second, "-")));
		Console.WriteLine ("Multiplication: " + ToString (PolynomialOperation (first, second, "*")));
	}
	
	static decimal[] PolynomialOperation (decimal[] a, decimal[] b, string op = "+")
	{
		int aLen = a.Length, bLen = b.Length;
		int minLenght = Math.Min (aLen, bLen);
		int shorter = minLenght == aLen ? 1 : 2;
		int resultLength;
		if (op == "*") {
			resultLength = aLen + bLen;
		} else {
			resultLength = Math.Max (aLen, bLen);
		}
		decimal[] result = new decimal[resultLength];
		
		if (op == "+" || op == "-") {
			for (int i = 0; i < minLenght; i++) {
				result [i] = op == "+" ? a [i] + b [i] : a [i] - b [i];
			}
			
			for (int i = minLenght; i < result.Length; i++) {
				result [i] = shorter == 1 ? b [i] : a [i];
			}
		} else {
			for (int i = 0; i < result.Length; i++) {
				result [i] = 0;
			}
			
			
			for (int i = 0; i < aLen; i++) {
				for (int j = 0; j < bLen; j++) {
					result [i + j] += (a [i] * b [j]);
				}
			}
		}
		return result;
	}
	
	static string ToString (decimal[] p)
	{
		string poly = "";
		string template = "{1}x^{0} ";
		
		for (int i = p.Length - 1; i >= 0; i--) {
			if (p [i] != 0 && i != 0) {
				template = "{1}x^{0} ";
				template += p [i - 1] >= 0 ? "+" : "";
				poly += String.Format (template, i, p [i]);
			} else if (i == 0) {
				poly += p [i].ToString ();
			}
		}
		
		return poly;
	}	
}















