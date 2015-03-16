using System;
using Points3D;
using System.Text.RegularExpressions;


class Points3DTest
{
	public static void Main ()
	{
		Point3D p1 = Point3D.Center;
		Point3D p2 = new Point3D (5, 5, 5);
		
		Console.WriteLine ("Point 1: " + p1.ToString ());
		Console.WriteLine ("Point 2: " + p2.ToString ());
		Console.WriteLine ("Distance between points: " + Vector3.Distance (p1, p2));
		
		Path path1 = new Path ("path1");
		path1.AddPoint (new Point3D (12, 55, 509));
		path1.AddPoint (new Point3D (1, 87, 22));
		path1.AddPoint (new Point3D (987, 873, 465));
		
		Path path2 = new Path ("path2");
		path2.AddPoint (new Point3D (1, 5, 9));
		path2.AddPoint (new Point3D (1, 7, 2));
		path2.AddPoint (new Point3D (9, 3, 6));
		
		if (PathStorage.SavePath (path1, PathStorageOptions.Erase)) {
			Console.WriteLine ("\nSaved " + path1.Name);
		}
		
		if (PathStorage.SavePath (path2, PathStorageOptions.Append)) {
			Console.WriteLine ("Saved " + path2.Name);
		}
		
		Path loadedPath1 = PathStorage.LoadPath ("path1");
		Path loadedPath2 = PathStorage.LoadPath ("path2");
		
		if (loadedPath1 != null && loadedPath2 != null) {
			Console.WriteLine ("\nLoaded both paths:");

            Console.WriteLine(loadedPath1.ToString());
            Console.WriteLine(loadedPath2.ToString());
        }
        else
        {
            Console.WriteLine("\nCouldn't load paths.");
        }
	}
}