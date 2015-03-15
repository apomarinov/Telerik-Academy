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
			return string.Format ("({0}, {1}, {2})", X, Y, Z);
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
		public string Name;
		
		public List<Point3D> Points {
			get {
				return new List<Point3D> (this.points);
			}
		}
		
		public Path (string name)
		{
			this.points = new List<Point3D> ();
			this.Name = name;
		}
		
		
		public void AddPoint (Point3D p)
		{
			this.points.Add (p);
		}
		
		public override string ToString ()
		{
			StringBuilder pathSB = new StringBuilder ();
			pathSB.AppendFormat ("Path: {0}\n", this.Name);
			
			for (int i = 0; i < this.points.Count; i++) {
				pathSB.AppendFormat ("P{0}: {1}\n", i + 1, this.points [i].ToString ());
			}
			
			pathSB.AppendFormat ("End:{0}\n", this.Name);
			return pathSB.ToString ();
		}
		
	}
	
	public enum PathStorageOptions
	{
		Erase,
		Append
	}
	
	public static class PathStorage
	{
		// do not change the format
		private const string startPathFormat = "=== Path: {0} ===\n";
		private const string endPathFormat = "=== End Path: {0} ===\n\n";
		private const string pointFormat = "{0} {1} {2}\n";
		private const string savedPathsFile = "../../saved_paths.txt";
		
		public static bool SavePath (Path path, PathStorageOptions op = PathStorageOptions.Append)
		{
			string currentSavedPaths = "";
			if (op == PathStorageOptions.Append && File.Exists (savedPathsFile)) {
				currentSavedPaths = File.ReadAllText (savedPathsFile);
			}
			
			StringBuilder savePath = new StringBuilder ();
			
			savePath.AppendFormat (startPathFormat, path.Name);
			foreach (Point3D p in path.Points) {
				savePath.AppendFormat (pointFormat, p.X, p.Y, p.Z);
			}
			savePath.AppendFormat (endPathFormat, path.Name);
			
			File.WriteAllText (savedPathsFile, currentSavedPaths + savePath.ToString ());
			
			return true;
		}
		
		public static Path LoadPath (string pathName)
		{
			string text = File.ReadAllText (savedPathsFile);
			Match pathMatch = Regex.Match (text, pathName + " ===(.*?(\n))+.*?===");
			
			if (!pathMatch.Success) {
				return null;
			}
			
			string pathText = pathMatch.Value.Split (new string[]{"==="}, StringSplitOptions.RemoveEmptyEntries) [1];
			string[] pointsInLines = pathText.Trim ().Split ('\n');	
			
			Path pathFromFile = new Path (pathName);
			
			string[] pointsFromStr;
			int pX, pY, pZ;
			foreach (string pointsStr  in pointsInLines) {
				pointsFromStr = pointsStr.Split (' ');
				
				if (!int.TryParse (pointsFromStr [0], out pX)) {
					pX = 0;
				}
				if (!int.TryParse (pointsFromStr [1], out pY)) {
					pY = 0;
				}
				if (!int.TryParse (pointsFromStr [2], out pZ)) {
					pZ = 0;
				}
				pathFromFile.AddPoint (new Point3D (pX, pY, pZ));
			}
			
			return pathFromFile;
		}
	}
}


