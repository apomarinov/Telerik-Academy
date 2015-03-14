using System;
using HomeworkClasses;

class GSMTest
{
	static void Main ()
	{
		// Since all the problems are about creating the GSM class, I completed them as a single problem.
		// The classes are in the HomeworkClasses.cs file, in the Solution's root directory and in the Solution Items in Visual Studio
		GSM iPhone = new GSM ("Apple", "iPhone", "6");
		
		Console.WriteLine ("GSM, minimum properties: \n=======");
		Console.WriteLine (iPhone + "=======");
		
		iPhone.Price = int.MaxValue;
		iPhone.Owner = "Go6ko";
		iPhone.Battery = new GSMBattery ("JHGASD6", 250, 14, GSMBatteryType.NiCd);
		iPhone.Display = new GSMDisplay (750, 1334, 16000000);
		Console.WriteLine ("\n\nGSM, full properties: \n=======");
		Console.WriteLine (iPhone + "=======");
		
		Console.WriteLine ("\n\nGSM, static property: \n=======");
		Console.WriteLine (GSM.iPhone4S);
	}
}