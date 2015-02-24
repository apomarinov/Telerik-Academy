// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayTools
{
	public static class ArrayTo
	{
		public static string String (int[] array, string separator = ", ")
		{
			return string.Join (separator, array.Select (v => v.ToString ()));
		}
		
		public static string String (char[] array, string separator = ", ")
		{
			return string.Join (separator, array.Select (v => v.ToString ()));
		}
	}
	
	public static class FindArraySequence
	{		
		public static int[] Increasing (int[] array)
		{
			int len = array.Length;
			int testElement = array [0],
			testCount = 0;
			int foundElement = testElement,
			foundCount = 0, increment = 0;
			
			for (int i = 0; i < len; i++, increment++) {
				if (testElement + increment == array [i]) {
					testCount++;
				} else {
					if (testCount > foundCount) {
						foundCount = testCount;
						foundElement = testElement;
					}
					
					testElement = array [i];
					i--;
					increment = -1;
					testCount = 0;
				}
			}
			
			if (testCount > foundCount) {
				foundCount = testCount;
				foundElement = testElement;
			}		
			
			int[] increasingSequence = new int[foundCount];
			for (int i = 0; i < foundCount; i++) {
				increasingSequence [i] = foundElement + i;
			}
			
			return increasingSequence;
		}
		
		public static int[] Equals (int[] array)
		{	
			int len = array.Length;
			int testElement = array [0],
			testCount = 0;
			int foundElement = testElement,
			foundCount = 0;
			
			for (int i = 0; i < len; i++) {
				if (testElement == array [i]) {
					testCount++;
				} else {
					if (testCount > foundCount) {
						foundCount = testCount;
						foundElement = testElement;
					}
					
					testElement = array [i];
					testCount = 1;
				}
			}
			
			if (testCount > foundCount) {
				foundCount = testCount;
				foundElement = testElement;
			}
			
			int[] longestSequence = new int[foundCount];
			for (int i = 0; i < foundCount; i++) {
				longestSequence [i] = foundElement;
			}
			
			return longestSequence;
		}
		
		public static int[] MaxSum (int[] arr)
		{
			int currentMaxSum = 0, startIndex = 0, endIndex = arr.Length - 1,
			maxSum = currentMaxSum;
			
			
			for (int i = 0, len = arr.Length; i < len; i++) {
				if (currentMaxSum <= 0) {
					currentMaxSum = 0;
					startIndex = i;
				}
				
				currentMaxSum += arr [i];
				
				if (maxSum < currentMaxSum) {
					maxSum = currentMaxSum;
					endIndex = i;
				}
			}
			
			int size = endIndex - startIndex + 1;
			int[] maxSumSequence = new int[size];
			for (int i = 0, j = startIndex; i < size; i++, j++) {
				maxSumSequence [i] = arr [j];
			}
			
			return maxSumSequence;
		}
		
		public static int[] Sum (int sumToFind, int[] arr)
		{
			int startIndex = 0, endIndex = 0, sum = 0;
			
			for (int i = 0, len = arr.Length; i < len; i++) {
				sum += arr [i];
				if (sum == sumToFind) {
					endIndex = i;
					break;
				} else if (sum > sumToFind) {
					sum = arr [i];
					startIndex = i;
				}
			}
			
			int[] sequence = new int[endIndex - startIndex + 1];
			for (int i = 0, len = sequence.Length; i < len; i++, startIndex++) {
				sequence [i] = arr [startIndex];
			}
			
			return sequence;
		}
	}
	
	public static class ValueFromArray
	{
		public static int SumOfArray (int[] arr)
		{
			int sum = 0;
			
			for (int i = 0, len = arr.Length; i < len; i ++) {
				sum += arr [i];
			}
			
			return sum;
		}
		
		public static int MostFrequentNumber (int[] arr)
		{
			int mode = arr.GroupBy (v => v)
				.OrderByDescending (g => g.Count ())
					.First ()
					.Key;
			
			return mode;
		}
	}
	
	public static class Sort
	{		
		public static void Selection (int[] arr)
		{
			int temp, smallest;			
			
			// I spend a lot of time trying to figure out the algorithm myself
			// and it was almost working, with only one loop, but I had to move
			// to the nex problem and looked it up on the interenet :(			
			for (int i = 0, len = arr.Length; i < len - 1; i++) {
				smallest = i;
				
				for (int j = i + 1; j < len; j++) {
					if (arr [j] < arr [smallest]) {
						smallest = j;						
					}
				}
				
				if (smallest != i) {
					temp = arr [smallest];
					arr [smallest] = arr [i];
					arr [i] = temp;
				}
			}
		}
		
		public static void Quick (int[] arr, int left, int right)
		{
			int i = left, j = right;
			int pivot = arr [(left + right) / 2];
			int temp;
			
			while (i <= j) {
				while (arr[i].CompareTo(pivot) < 0) {
					i++;
				}
				
				while (arr[j].CompareTo(pivot) > 0) {
					j--;
				}
				
				if (i <= j) {
					temp = arr [i];
					arr [i] = arr [j];
					arr [j] = temp;
					
					i++;
					j--;
				}
			}
			
			// Recursive calls
			if (left < j) {
				Quick (arr, left, j);
			}
			
			if (i < right) {
				Quick (arr, i, right);
			}
		}
	}
	
	public static class Search
	{		
		public static int[] Binary (int numToFind, int[] arr)
		{
			int foundAtIndex = -1, operations = 0;
			int low = 0, high = arr.Length - 1, mid = (low + high) / 2;
			
			for (; foundAtIndex == -1;) {
				if (numToFind == arr [mid]) {
					foundAtIndex = mid;
					break;
				} else if (numToFind > arr [mid]) {
					low = mid + 1;
				} else if (numToFind < arr [mid]) {
					high = mid - 1;
				}
				mid = (low + high) / 2;
				operations++;
				
				if (mid == high) {
					break; // check for not found
				}
			}
			
			int[] result = new int[2];
			result [0] = foundAtIndex;
			result [1] = operations;
			return result;
		}
		
		public static int[] SieveOfEratosthenes (int end)
		{
			HashSet<int> NoPrime = new HashSet<int> ();
			List<int> primes = new List<int> ();
			
			for (int x = 2; x < end; x++) {
				for (int y = x * 2; y < end; y = y + x) {
					if (!NoPrime.Contains (y)) {
						NoPrime.Add (y);
					}
					
				}
			}
			
			for (int z = 2; z < end; z++) {
				if (!NoPrime.Contains (z)) {
					primes.Add (z);
				}
			}
					
			return primes.ToArray ();
		}
	}
}












