using System;

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	    output
//4 
//2 3 3 4 
//0 2 3 4   17
//3 7 1 2 
//4 3 3 2	

class Program
{
    static void Main(string[] args)
    {
        string[] allLines = System.IO.File.ReadAllLines(@"../../input.txt");
        int size = int.Parse(allLines[0]);
        int[,] m = new int[size, size];

        // read the matrix from the file
        string[] currentLineNumbers;
        for (int i = 0; i < size; i++)
        {
            // split the current line of numbers for parsing
            currentLineNumbers = allLines[i + 1].Split(' ');
            for (int j = 0; j < size; j++)
            {
                m[i, j] = int.Parse(currentLineNumbers[j]);
            }
        }
        // find the sub matrix with max sum with size 2
        int[,] maxSumMatrix = MaxSumSquare(m, 2);

        // print it and find the sum too
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum += maxSumMatrix[i, j];
                Console.Write(maxSumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Sum: " + sum);
    }

    // using the max sum square from previous homework
    static int[,] MaxSumSquare(int[,] m, int squareSide)
    {
        int[,] maxSumSquare = new int[squareSide, squareSide];
        int rows = m.GetLength(0),
        cols = m.GetLength(1);
        int sum = 0, maxSum = 0;
        int startRow = -1,
        endCol = -1;

        // the first two loops, go over every element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // loop a square matrix with size squareSide, starting from current element
                // if the end of it doesnt overlap the size of the start matrix
                if (i + squareSide <= rows && j + squareSide <= cols)
                {
                    for (int k = 0; k < squareSide; k++)
                    {
                        for (int l = 0; l < squareSide; l++)
                        {
                            sum += m[i + k, j + l];
                        }
                    }
                }
                // when out of looping in a square check the sum of it
                if (maxSum < sum)
                {
                    maxSum = sum;
                    startRow = i;
                    endCol = j;
                }
                sum = 0;
            }
        }

        // i and j are for access in the new matrix
        // k and l are for getting the elements in the start matrix 
        // that make the square with largest sum
        for (int i = 0, k = startRow; i < squareSide; i++, k++)
        {
            for (int j = 0, l = endCol; j < squareSide; j++, l++)
            {
                maxSumSquare[i, j] = m[k, l];
            }
        }

        return maxSumSquare;
    }
}