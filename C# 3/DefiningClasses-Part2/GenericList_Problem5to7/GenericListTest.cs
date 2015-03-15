using System;
using CustomGenerics;

class GenericListTest
{
	public static void Main ()
	{
		GenericList<int> list = new GenericList<int> (3);
		list.Add (1);
		list.Add (2);
		list.Add (3);
		list.Add (4);
		list.Add (5);
		
		Console.WriteLine ("Added new elements: ");
		Console.WriteLine (list.ToString ());
		
		Console.WriteLine ("Access by index 2: (not said to use indexers!): " + list.ItemAt (2));
		
		Console.WriteLine ("After insert 10 at index 1: ");
		list.InsertAt (1, 10);
		Console.WriteLine (list.ToString ());
		
		Console.WriteLine ("After remove at index 5: ");
		list.RemoveAt (5);
		Console.WriteLine (list.ToString ());		

		Console.WriteLine ("Min: " + list.Min ());
		Console.WriteLine ("Max: " + list.Max ());
		
		Console.WriteLine ("Index of 10: " + list.IndexOf (10));
		Console.WriteLine ("Index of 100: " + list.IndexOf (100));
		
		list.Clear ();
		Console.WriteLine ("After clearing: Count - {0}, Capacity = {1}", list.Count, list.Capacity);
	}
}