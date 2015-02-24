using System;
using MatrixTools;

// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MainClass
{
	static int rows, cols, squareSize = 3;
	static int[, ] matrix = {
		{1, 1, 1, 3, 5, 6, 100, 100, 100},
		{1, 6, 999, 2, 23, 3, 100, 100, 100},
		{2, 1, 30, 30, -6, 2, 33, 2, 1},
		{2, 1, 3, 3, -6, 2, 1, 1, 2},
	};
	static int[] paintStart = {-1, -1};
	static int[] paintEnd = {-1, -1};
	
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
		int[,] maxSumMatrix = MaxSumSquare (matrix, squareSize);
		
		Console.WriteLine ("Matrix: ");
		Matrix.Print (matrix, paintStart, paintEnd);
		Console.WriteLine ("\nSum: " + Matrix.Sum (maxSumMatrix));
		Matrix.Print (maxSumMatrix);
	}

	static bool ReadInput ()
	{
		Console.Write ("Enter n: ");
		if (!int.TryParse (Console.ReadLine (), out rows) || rows <= 0) {
			return false;
		}
		
		Console.Write ("Enter m: ");
		if (!int.TryParse (Console.ReadLine (), out cols) || cols < 0) {
			return false;
		}
		
		Console.Write ("Enter square size: ");
		if (!int.TryParse (Console.ReadLine (), out squareSize) || SquareIsLargerThanMatrix ()) {
			return false;
		}
		
		matrix = new int[rows, cols];
		Console.WriteLine ("Enter matrix: ");
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < cols; j++) {
				Console.Write ("[{0}, {1}] = ", i, j);
				if (!int.TryParse (Console.ReadLine (), out matrix [i, j])) {
					return false;
				}
			}
			Console.WriteLine ();
		}
		
		return true;
	}
	
	static bool SquareIsLargerThanMatrix ()
	{
		return squareSize <= 0 || squareSize > rows || squareSize > cols;
	}
	
	static int[,] MaxSumSquare (int[,] m, int squareSide)
	{
		int rows = m.GetLength (0),
		cols = m.GetLength (1);
		int sum = 0, maxSum = 0;
		int startRow = -1,
		endCol = -1;
		
		// the first two loops, go over every element in the matrix
		for (int i = 0; i < rows; i++) {
			for (int j = 0; j < cols; j++) {
				// loop a square matrix with size squareSide, starting from current element
				// if the end of it doesnt overlap the size of the start matrix
				if (i + squareSide <= rows && j + squareSide <= cols) {
					for (int k = 0; k < squareSide; k++) {
						for (int l = 0; l < squareSide; l++) {
							sum += matrix [i + k, j + l];
						}
					}
				}
				// when out of looping in a square check the sum of it
				if (maxSum < sum) {
					maxSum = sum;
					startRow = i;
					endCol = j;
				}
				sum = 0;
			}
		}
		int[,] maxSumSquare = new int[squareSide, squareSide];
		
		// i and j are for access in the new matrix
		// k and l are for getting the elements in the start matrix 
		// that make the square with largest sum
		for (int i = 0, k = startRow; i < squareSide; i++, k++) {
			for (int j = 0, l = endCol; j < squareSide; j++, l++) {
				maxSumSquare [i, j] = m [k, l];
			}
		}
		
		paintStart [0] = startRow;
		paintStart [1] = startRow + squareSide - 1;
		paintEnd [0] = endCol;
		paintEnd [1] = endCol + squareSide - 1;
		
		return maxSumSquare;
	}
}










