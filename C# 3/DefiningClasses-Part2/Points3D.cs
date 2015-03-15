using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;

namespace Points3D
{
	public struct Point3D
	{
		public int X;
		public int Y;
		public int Z;
		
		private static readonly Point3D center = new Point3D (0, 0, 0);
		
		public static Point3D Center {
			get {
				return center;
			}
		}
		
		public Point3D (int x, int y, int z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}
		
		public override string ToString ()
		{
			return string.Format ("[Point3D: X={0}, Y={1}, Z={2}]", X, Y, Z);
		}
	}
	
	public static class Vector3
	{
		public static double Distance (Point3D p1, Point3D p2)
		{
			return Math.Sqrt (Math.Pow ((p1.X - p2.X), 2) + Math.Pow ((p1.Y - p2.Y), 2) + Math.Pow ((p1.Z - p2.Z), 2));
		}
	}
	
	public class Path
	{
		private List<Point3D> points;
		
		public List<Point3D> Points {
			get {
				return new List<Point3D> (this.points);
			}
		}
		
		public Path ()
		{
			this.points = new List<Point3D> ();
		}
		
		
		public void AddPoint (Point3D p)
		{
			this.points.Add (p);
		}
	}
	
	public static class PathStorage
	{
		public static void SavePath (Path path, string pathName)
		{
			StringBuilder sb = new StringBuilder ();
			
			sb.AppendFormat ("=== Path: {0} ===\n", pathName);
			foreach (Point3D p in path.Points) {
				sb.AppendFormat ("{0} {1} {2}\n", p.X, p.Y, p.Z);
			}
			sb.AppendFormat ("=== End Path: {0} ===\n\n", pathName);
			
			File.WriteAllText ("../../saved_path_" + pathName + ".txt", sb.ToString ());
		}
		
//		public static Path LoadPath (string filePath, string pathName)
//		{
//			if (File.Exists (filePath)) {
//				string text = File.ReadAllText (filePath);
//				string pathText = Regex.Match (text, pathName + " ===(.*?(\n))+.*?===").Value.Split (new string[]{"==="}, StringSplitOptions.RemoveEmptyEntries) [1];
//			}
//		}
	}
}

//string file2 = System.IO.File.ReadAllText(@"../../input2.txt");
//System.IO.File.WriteAllText(@"../../output.txt", file1 + file2);






