using System;
using PersonClass;

class PersonTest
{
	public static void Main ()
	{
		Person p = new Person ("Go6ko");
		Person p1 = new Person ("Go6inko", 44);
		Console.WriteLine (p);
		Console.WriteLine (p1);
	}
}