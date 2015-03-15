using System;
using GSMModules;
using Calls;

class GSMCallHistoryTest
{
	public static void Main ()
	{
		// Again, you can find the classes for the whole homework in the GSMModules.cs and Calls.cs files, in the Solution's root directory and in the Solution Items in Visual Studio
		
		GSM phone = new GSM ("Nokia", "Tuhla", "3310");
		Call call1 = new Call (new DateTime (2015, 3, 14, 12, 12, 10), "048 155 22", 69.69);
		Call call2 = new Call (new DateTime (2015, 3, 14, 13, 20, 0), "112", 2.5);
		Call call3 = new Call (new DateTime (2015, 3, 14, 14, 10, 22), "911", 12.4);
		
		phone.AddCall (call1);
		phone.AddCall (call2);
		phone.AddCall (call3);
		
		Console.WriteLine ("Call history:");
		Console.WriteLine (phone.CallHistoryToString ());
		
		Console.WriteLine ("Total Price: " + phone.CallsPrice (0.37).ToString ("F2"));
		
		phone.RemoveCall (call1);
		Console.WriteLine ("Total Price without longest call: " + phone.CallsPrice (0.37).ToString ("F2"));
		
		phone.ClearCallHistory ();
		Console.WriteLine ("After clearing call history:");
		Console.WriteLine (phone.CallHistoryToString ());
	}
}