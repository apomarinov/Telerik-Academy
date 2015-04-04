using System;
using SchoolSystem;

// Problem 1
// Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
// mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
// Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

// Problem 2
// Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

// Problem 3
// Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
// and by social security number (as second criteria, in increasing order).

class StudentTest
{
	public static void Main ()
	{
		Student az = new Student ("tozi", "onzi", 87634567, "nqkade si tam dale4", "088128832", "epa@tuka.tam", 
		                          "nai dobriq", University.TU, Faculty.Robotics, Specialty.Informatics);
		Student ti = new Student ("go6i", "mo6i", 81723, "prez 9 planini v 10ta", "088123123", "a@a.a",
		                          "kodene", University.NBU, Faculty.Electronics, Specialty.Informatics);
		
		// problem 1
		Console.WriteLine ("Student 1:");
		Console.WriteLine (az);
		Console.WriteLine ("Student 2:");
		Console.WriteLine (ti);
		Console.WriteLine ("Student 1 Equals Student 2: " + az.Equals (ti));
		Console.WriteLine ("Student 1 != Student 2: " + (az != ti));
		Console.WriteLine ("Student 1 Hash: " + az.GetHashCode ());
		Console.WriteLine ("Student 2 Hash: " + ti.GetHashCode ());
		Console.WriteLine ();
		
		// problem 2
		Console.WriteLine ("Clone student 1...");
		Student clone = (Student)az.Clone ();
		Console.WriteLine ("Change new student's name...");
		clone.FirstName = "new fname";
		clone.LastName = "new lname";
		Console.WriteLine ("Print the original and the clone:\n");
		Console.WriteLine (az);
		Console.WriteLine (clone);
		
		// problem 3
		Console.WriteLine ("Compare Student 1 and its clone with new names: " + az.CompareTo (clone));
	}
}



