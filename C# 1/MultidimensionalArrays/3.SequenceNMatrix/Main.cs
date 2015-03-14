using System;
using System.Collections.Generic;

// We are given a matrix of strings of size N x M. Sequences in the matrix we define 
// as sets of several neighbour elements located on the same line, column or diagonal.
//	Write a program that finds the longest sequence of equal strings in the matrix.
//		Example:
//		
//		matrix	
//		ha	fifi	ho	hi
//		fo	ha	hi	xx
//		xxx	ho	ha	xx
// 		result
//		ha, ha, ha		
// 		
//		matrix
//		s	qq	s
//		pp	pp	s
//		pp	qq	s
//		result
//		s, s, s

class MainClass
{
	static string[, ] matrix = {
		{"ha", "fifi", "ho", "hi"},
		{"fo", "ha", "hi", "xx"},
		{"xxx", "xxx", "ha", "xx"}
//		{"s", "qq", "s"},
//		{"pp", "pp", "s"},
//		{"pp", "qq", "s"}
	};
	
	public static void Main ()
	{
		PrintOutput ();
	}

	static void PrintOutput ()
	{
		LongestNeighbourSequence (matrix);
	}

	static void LongestNeighbourSequence (string[,] m)
	{
		int r = m.GetLength (0);
		int c = m.GetLength (1);
		bool foundMatch = false;
		
		int firstMatchI = 0, firstMatchJ = 0;
		int allMatchesI = 0, allMatchesJ = 0;
		
		int deltaI = 0, deltaJ = 0;

		List<string> sequence = new List<string> ();
		List<string> maxSequence = new List<string> ();
		string currentElement = "";
		
		// loops for getting each element
		for (int i = 0; i < r; i++) {
			for (int j = 0; j < c; j++) {
				currentElement = m [i, j];
				
				// reassign i and j so we can check each element that surounds the current one
				firstMatchI = i;
				firstMatchJ = j;
				// this checks every element that is around the current one
				if (firstMatchJ + 1 < c && currentElement == m [firstMatchI, firstMatchJ + 1]) {
					foundMatch = true;
					firstMatchJ++;
				} else if (firstMatchJ + 1 < c && firstMatchI + 1 < r && currentElement == m [firstMatchI + 1, firstMatchJ + 1]) {
					foundMatch = true;
					firstMatchI++;
					firstMatchJ++;
				} else if (firstMatchI + 1 < r && currentElement == m [firstMatchI + 1, firstMatchJ]) {
					foundMatch = true;
					firstMatchI++;					
				} else if (firstMatchI + 1 < r && firstMatchJ - 1 >= 0 && currentElement == m [firstMatchI + 1, firstMatchJ - 1]) {
					foundMatch = true;
					firstMatchI++;
					firstMatchJ--;
				} else if (firstMatchJ - 1 >= 0 && currentElement == m [firstMatchI, firstMatchJ - 1]) {
					foundMatch = true;
					firstMatchJ--;
				} else if (firstMatchI - 1 >= 0 && firstMatchJ - 1 >= 0 && currentElement == m [firstMatchI - 1, firstMatchJ - 1]) {
					foundMatch = true;
					firstMatchI--;
					firstMatchJ--;
				} else if (firstMatchI - 1 >= 0 && currentElement == m [firstMatchI - 1, firstMatchJ]) {
					foundMatch = true;
					firstMatchI--;
				} else if (firstMatchI - 1 >= 0 && firstMatchJ + 1 < c && currentElement == m [firstMatchI - 1, firstMatchJ + 1]) {
					foundMatch = true;
					firstMatchI--;
					firstMatchJ++;
				}
				if (foundMatch) {
					foundMatch = false;
					// if an equal element is found
					// add the current one and the one found
					sequence.Add (m [i, j]);
					sequence.Add (m [firstMatchI, firstMatchJ]);
					// these deltas hold the amount of each index needed to move in the same direction
					// in which the matching element is found
					deltaI = firstMatchI - i;
					deltaJ = firstMatchJ - j;
					// if deltaI is < 0 it means we are going back - up the matrix
					// to elements already checked so dont
					if (deltaI >= 0) {
						// set these to the next element in the same direction
						allMatchesI = firstMatchI + deltaI;
						allMatchesJ = firstMatchJ + deltaJ;
						// check all the elements in the direction the first one was found
						while (allMatchesI < r && allMatchesJ < c && allMatchesI >= 0 && allMatchesJ >= 0) {
							if (m [firstMatchI, firstMatchJ] == m [allMatchesI, allMatchesJ]) {
								sequence.Add (m [allMatchesI, allMatchesJ]);
							}
							allMatchesI += deltaI;
							allMatchesJ += deltaJ;
						}
					}
				}
				// get new sequence if its greater than the max one
				if (maxSequence.Count < sequence.Count) {
					maxSequence.Clear ();
					maxSequence = sequence.ConvertAll (str => str);
				}
				// clear the current sequence to start over
				sequence.Clear ();
			}
		}
		
		string[] s = maxSequence.ToArray ();
		for (int a = 0; a < maxSequence.Count; a++) {
			Console.Write (s [a] + (a < maxSequence.Count - 1 ? ", " : ""));
		}
        Console.WriteLine();
	}	
}










