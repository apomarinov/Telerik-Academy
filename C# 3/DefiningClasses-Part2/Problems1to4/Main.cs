using System;
using Points3D;
using System.Text.RegularExpressions;


class MainClass
{
	public static void Main ()
	{
		Point3D p1 = Point3D.Center;
		Point3D p2 = new Point3D (5, 5, 5);
		
		Console.WriteLine (p1.ToString ());
		Console.WriteLine (p2.ToString ());
		Console.WriteLine ("Distance between points: " + Vector3.Distance (p1, p2));
		
		String text = "98 gf98h7d9 fg87h89d7gh97 === Path: apo ===\n1 2 3\n4 5 6\n6 7 8\n=== End Path: apo ===9 sg7d6fg876 765g75 75sfgh sfh";
		
		string pathName = "apo";
		string pathText = Regex.Match (text, pathName + " ===(.*?(\n))+.*?===").Value.Split (new string[]{"==="}, StringSplitOptions.RemoveEmptyEntries) [1];
		string[] pointsInLines = pathText.Trim ().Split('\n');
		Path
	}
}