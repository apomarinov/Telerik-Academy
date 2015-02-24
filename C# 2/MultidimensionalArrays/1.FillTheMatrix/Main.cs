using System;
using MatrixTools;

// Write a program that fills and prints a matrix of size (n, n) as shown below:
// Example for n=4:
// 		
// a)	
// 1 5	9	13
// 2 6	10	14
// 3 7	11	15
// 4 8	12	16
// b) 	
// 1 8	9	16
// 2 7	10	15
// 3 6	11	14
// 4 5	12	13
// c)
// 7 11	14	16
// 4 8	12	15
// 2 5	9	13
// 1 3	6	10
// d)*
// 1 12	11	10
// 2 13	16	9
// 3 14	15	8
// 4 5	6	7

class MainClass
{
	static int n = 4;
	
	public static void Main ()
	{
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
		// Again, in this homework, I've wrote an external static class with functions used throughout
		// the homework - MatrixTools.cs. I also use the one form the previous homework - ArrayTools.cs
		Console.WriteLine (" --- Matrix A --- ");
		Matrix.Print (MatrixA ());
		Console.WriteLine ("\n --- Matrix B --- ");
		Matrix.Print (MatrixB ());
		Console.WriteLine ("\n --- Matrix C --- ");
		Matrix.Print (MatrixC ());
		Console.WriteLine ("\n --- Matrix D* --- ");
		Matrix.Print (MatrixD ());
	}

	static bool ReadInput ()
	{		
		Console.Write ("Enter n: ");
		if (!int.TryParse (Console.ReadLine (), out n) || n <= 0) {
			return false;
		}
		return true;
	}
	
	static int[,] MatrixA ()
	{
		int[,] a = new int[n, n];
		bool down = true;
		
		for (int i = 0, j = 0, count = 1;; count++) {
			a [i, j] = count;

			i++;
			if (i == n) {
				i = 0;
				j++;
			}
			if (j == n) {
				break;
			}
		}
		
		return a;
	}
	
	static int[,] MatrixB ()
	{
		int[,] a = new int[n, n];
		bool down = true;
		
		for (int i = 0, j = 0, count = 1;; count++) {
			a [i, j] = count;
			
			// loop i to go from 0 to n or from n to 0
			// based on j
			if ((j + 1) % 2 == 0) {
				i--;
			} else {
				i++;
			}
			// reset i to 0 or n if its equal to rows - going down the matrix
			// or if its equal -1 - going up the matrix and move j to next column
			if (i == n || !down && i == -1) {
				if ((j + 1) % 2 == 0) {
					i = 0;
				} else {
					down = false;
					i = n - 1;
				}
				j++;
			}
			// break out of loop when j is equal to number of columns
			if (j == n) {
				break;
			}
		}
		
		return a;
	}
	
	static int[,] MatrixC ()
	{
		int[,] a = new int[n, n];
		bool secondHalf = false;
		
		for (int i = n - 1, j = 0, count = 1, indexMover = n - 1;; count++) {
			a [i, j] = count;
			
			i++;
			j++;
			if (i >= n || j >= n) {
				if (secondHalf) {
					indexMover++;
					if (indexMover == n) {
						break;
					}
					i = 0;
					j = indexMover;
				} else {
					indexMover--;
					if (indexMover < 0) {
						indexMover = 1;
						i = 0;
						j = indexMover;
						secondHalf = true;
						continue;
					}
					i = indexMover;
					j = 0;
				}
			}
		}
		
		return a;
	}
	
	static int[,] MatrixD ()
	{
		int[,] a = new int[n, n];
		bool down = true,
		right = false,
		up = false,
		left = false;
		int offset = 0;
		
		// you may think this was a toughy, but after solving the first three, I guess I got better
		// at thinking the right way about it, and saw that this one is actually quite straightforward
		for (int i = 0, j = 0, count = 1; count <= n * n; count++) {
			a [i, j] = count;
			
			// this if moves down the rows
			if (i == n - offset - 1 && down) {
				down = false;
				right = true;
			} else if (down) {
				i++;
			}
			// this if goes right the column
			if (j == n - offset - 1 && right) {
				right = false;
				up = true;
			} else if (right) {
				j++;
			}
			// this if goes up the rows
			if (i == 0 + offset && up) {
				up = false;
				left = true;
			} else if (up) {
				i--;
			}
			// this if goes left th columns and inccrements the offset and resets the loop around
			// the matrix, but with one level (the offset) inward :)
			if (j == 0 + offset + 1 && left) {
				left = false;
				down = true;
				i++;
				offset++;
			} else if (left) {
				j--;
			}
		}
		
		return a;
	}
}









