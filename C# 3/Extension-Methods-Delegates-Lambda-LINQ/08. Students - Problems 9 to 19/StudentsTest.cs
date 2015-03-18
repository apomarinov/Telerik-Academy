using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Students;

class StudentsTest
{
    static void Main()
    {
        Console.WriteLine("When a student is printed, its a very long string,\n so please go the Properties of the console and\n increase the Screen Buffer Size and Window Size width\n of the window to like 150, and then uncoment the return below.");
        return;
        // OMG WHAT ARE ALL THESE STUDENTS, did ya write them by hand?
        // again, the data is generated from generatedate.com and reformated in Sublime Text
        Student[] students = new[]{
			new Student("Linda", "Moses", "primis.in@abv.bg", "17719", "02-760-324-4695", new List<int>(){2, 3, 4, 6, 6} , 4),
			new Student("Garrison", "Strong", "vehicula.Pelle@vel.edu", "15636", "1-809-778-0877",  new List<int>(){2, 3, 4, 5}, 2),
			new Student("Tiger", "Parrish", "senectus.et.netus@atpreum.net", "13352", "1-407-125-7261", new List<int>(){4, 5} , 1),
			new Student("Octavius", "Duffy", "erat.volutpat@arcuV.com", "14650", "1-318-138-9517", new List<int>(){4, 6} , 3),
			new Student("Buffy", "Odom", "non.leo@aliquet.com", "19317", "1-178-514-0493", new List<int>(){2, 3, 4, 5, 6, 6, 6} , 4),
			new Student("Stella", "Evans", "Maecenas.malesuada@elit.com", "14506", "1-818-846-8678", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Maris", "Griffith", "non.justo@necmollisvitae.ca", "15973", "1-673-906-6258", new List<int>(){2, 3, 4, 5} , 2),
			new Student("Adrian", "Christian", "lorem.vehicula@Uttint.com", "17202", "1-751-265-0577", new List<int>(){2, 3, 4, 5} , 4),
			new Student("Deacon", "Thomas", "malesuada.Integer@sedpis.net", "10528", "1-370-633-3276", new List<int>(){2, 3, 4, 5} , 3),
			new Student("Abra", "Kirkland", "odio.sagittis@duiin.org", "14845", "1-491-655-4094", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Latifah", "Patton", "luctus.ipsum@purusg.net", "19117", "02-685-109-6295", new List<int>(){2, 3, 4, 5} , 4),
			new Student("Ruby", "Bradford", "odio.semper@urnanec.ca", "19606", "1-478-254-3407", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Vincent", "Kirby", "Cras.sed@quam.org", "14114", "1-329-535-7977", new List<int>(){4, 6} , 3),
			new Student("Leah", "Strong", "auctor@nisiMauris.ca", "14536", "1-869-748-8230", new List<int>(){4, 5} , 4),
			new Student("Jackson", "Ward", "vel.turpis@maurisrhoncus.com", "13338", "1-966-166-5830", new List<int>(){4, 5} , 3),
			new Student("Madaline", "Bowman", "euismod@abv.bg", "15404", "1-396-559-8854", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Emmanuel", "Jones", "sociosqu.ad@quam.edu", "10823", "1-120-495-5468", new List<int>(){2, 3, 4, 6} , 4),
			new Student("Hasad", "Sears", "Lorem@Nullaeuneque.net", "17217", "1-824-508-3505", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Marshall", "English", "Mauris.eu@lectus.co.uk", "18771", "02-856-585-6740", new List<int>(){2, 3, 4, 6} , 1),
			new Student("Aspen", "Contreras", "nisl.Nulla.eu@nequam.com", "12437", "1-193-183-6629",  new List<int>(){2, 3, 4, 5}, 3),
			new Student("Cody", "Howell", "iaculis.nec@dolor.edu", "17216", "1-972-455-1013", new List<int>(){2, 3, 4, 5} , 4),
			new Student("Kalia", "Hines", "malesuada.id@nisiAenet.org", "18458", "1-738-821-9970", new List<int>(){4, 5} , 1),
			new Student("Rosalyn", "Bryant", "velit.Pellentesque@abv.bg", "13606", "1-132-108-6460", new List<int>(){4, 5} , 3),
			new Student("Dustin", "Byrd", "eget.nisi.dictum@vulput.net", "17520", "1-888-156-8330", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Basia", "Mathis", "urna.Nullam@velqua.edu", "13489", "1-567-395-5541", new List<int>(){2, 3, 4, 6} , 1),
			new Student("Guinevere", "Booth", "libero.dui@tellusjustosit.org", "16062", "02-397-497-5810", new List<int>(){2, 3, 4, 5} , 4),
			new Student("Lionel", "Wilder", "molestie@tristi.org", "12899", "1-520-865-5035", new List<int>(){2, 3, 4, 6} , 1),
			new Student("Orlando", "Reilly", "nibh@semelitpharetra.ca", "14806", "1-985-595-6248", new List<int>(){2, 3, 4, 5} , 2),
			new Student("Chris", "Solomon", "adipiscing.elit@infaucibus.org", "13180", "1-986-342-5268",  new List<int>(){2, 3, 4, 5}, 3),
			new Student("Rudyard", "Vance", "In@idnunc.co.uk", "17932", "02-610-993-2388", new List<int>(){2, 3, 4, 5} , 4),
			new Student("Piper", "Gamble", "Aliquam@posuerevulputus.ca", "12369", "02-997-710-1123", new List<int>(){2, 3, 4, 5} , 2),
			new Student("Leroy", "Donaldson", "aliquet.odio@ipsumpin.org", "18254", "1-471-156-8272", new List<int>(){2, 3, 4, 5} , 3),
			new Student("Graham", "Nelson", "varius.Nam@tempus.net", "18456", "1-234-797-7363", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Violet", "Herring", "tincidunt@nequeven.edu", "19117", "1-892-145-7034",  new List<int>(){2, 3, 4, 5}, 4),
			new Student("Felix", "Hahn", "consectetue.est@aatvel.edu", "15806", "1-534-201-8468", new List<int>(){2, 3, 4, 5} , 3),
			new Student("Quin", "Alexander", "egestas@nondapibusrutrum.ca", "19822", "1-374-410-1862",  new List<int>(){2, 3, 4, 5}, 3),
			new Student("Aretha", "Mcguire", "Integer.id.magna@abv.bg", "17028", "1-504-414-8624", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Deborah", "Farrell", "blandit.viverra@orci.co.uk", "11343", "1-692-210-0858", new List<int>(){2, 3, 4, 5} , 2),
			new Student("Tasha", "Juarez", "ut@elitpellentesque.co.uk", "12169", "1-436-962-9353", new List<int>(){2, 3, 4, 5} , 4),
			new Student("Conan", "Wilkerson", "laoreet@egestas.edu", "14606", "1-856-546-2492", new List<int>(){2, 3, 4, 5} , 1),
			new Student("Elijah", "Lee", "nulla@ettristique.ca", "10235", "1-394-926-5822", new List<int>(){2, 3, 4, 5} , 3),
			new Student("Neve", "Bernard", "Morbi.metus@enimco.org", "19677", "1-874-917-2914", new List<int>(){2, 3, 4, 5} , 1)
        };

        // Problem 9 and 10
        // Create a List<Student> with sample students. Select only the students that are from group number 2.
        // Use LINQ query. Order the students by FirstName.

        // Extension Methods
        //var studentsFromGroup2 = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
        // LINQ
        var studentsFromGroup2 = from st in students
                                 where st.GroupNumber == 2
                                 orderby st.FirstName
                                 select st;

        Console.WriteLine("Problem 9 and 10");
        Console.WriteLine("Students from group 2: ");
        PrintStudents(studentsFromGroup2.ToArray<Student>());
        // ===============================================================

        // Problem 11
        //Extract all students that have email in abv.bg.
        //Use string methods and LINQ.

        // Extension Methods
        //var studentsFromABV = students.Where(st => st.Email.Contains("abv.bg"));
        // LINQ
        var studentsFromABV = from st in students
                                 where st.Email.Contains("abv.bg")
                                 select st;

        Console.WriteLine("Problem 11");
        Console.WriteLine("Students email in abv.bg: ");
        PrintStudents(studentsFromABV.ToArray<Student>());
        // ===============================================================


        // Problem 12
        //Extract all students with phones in Sofia.
        //Use LINQ.

        var studentsWithPhonesInSofia = from st in students
                                          where st.Phone.StartsWith("02")
                                          select st;

        Console.WriteLine("Problem 12");
        Console.WriteLine("Students with phones in Sofia: ");
        PrintStudents(studentsWithPhonesInSofia.ToArray<Student>());
        // ===============================================================


        // Problem 13
        // Select all students that have at least one mark Excellent (6) 
        // into a new anonymous class that has properties – FullName and Marks.
        // Use LINQ.

        var studentsWithMark6 = from st in students
                                where st.Marks.Contains(6)
                                select new {FullName = st.FirstName + " " + st.LastName, Marks = st.MarksToString()};

        Console.WriteLine("Problem 13");
        Console.WriteLine("Students with atleast one mark 6: ");
        foreach (var student in studentsWithMark6)
        {
            Console.WriteLine("FullName: {0} Marks: {1}", student.FullName.PadRight(18, ' '), student.Marks.PadRight(12, ' '));
        }
        Console.WriteLine("\n");
        // ===============================================================



        //Problem 14. Extract students with two marks

        //Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.

        var studentsWithTwoMarks = students.Where(st => st.Marks.Count == 2);

        Console.WriteLine("Problem 14");
        Console.WriteLine("Students with only two marks: ");
        foreach (var student in studentsWithTwoMarks)
        {
            Console.WriteLine("First Name: {0} Marks: {1}", student.FirstName.PadRight(10, ' '), student.MarksToString().PadRight(12, ' '));
        }
        Console.WriteLine("\n");
        // ===============================================================

         
        // Problem 15. Extract marks
        // Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

        var studentsMarksOf2006 = from st in students
                                  where st.FacultyNumber.EndsWith("06")
                                  select st;

        Console.WriteLine("Problem 15");
        Console.WriteLine("Marks of students form 2006: ");
        foreach (var student in studentsMarksOf2006)
        {
            Console.WriteLine("FirstName: {0} FN: {1} Marks: {2}", student.FirstName.PadRight(10, ' '), student.FacultyNumber.PadRight(8, ' '), student.MarksToString().PadRight(12, ' '));
        }
        Console.WriteLine("\n");
        // ===============================================================


        //Problem 16.* Groups

        //Create a class Group with properties GroupNumber and DepartmentName.
        //Introduce a property GroupNumber in the Student class.
        //Extract all students from "Mathematics" department.
        //Use the Join operator.

        Group[] departments = new Group[] { 
            new Group(1, "Mathematics"),
            new Group(2, "History"),
            new Group(3, "Physics"),
            new Group(4, "Programming")
        };

        var studentsGroups = from st in students
                             join d in departments on st.GroupNumber equals d.GroupNumber
                             where st.GroupNumber == 1
                             select new { FullName = st.FirstName + " " + st.LastName, Department = d.DepartmentName };

        Console.WriteLine("Problem 16");
        Console.WriteLine("Students from department Mathematics");
        foreach (var st in studentsGroups)
        {
            Console.WriteLine("FullName: {0} Department: {1}", st.FullName.PadRight(18, ' '), st.Department.PadRight(12, ' '));
        }
        Console.WriteLine("\n");
        // ===============================================================



        //Problem 17. Longest string

        //Write a program to return the string with maximum length from an array of strings.
        //Use LINQ.
        // ======>>>>>>>>> I will just output the student with longest email

        string longestEmail = students.OrderByDescending(st => st.Email.Length).First().Email;

        Console.WriteLine("Problem 17");
        Console.WriteLine("Longest email: " + longestEmail + "\n");
        // ===============================================================



        //Problem 18. Grouped by GroupNumber

        //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        //Use LINQ.

        var studentsByGroups = from st in students
                               group st by st.GroupNumber into studentGroup
                               select new { StudentGroup = studentGroup.Key, studentsInGroup = studentGroup };

        Console.WriteLine("Students grouped by group numbers USING LINQ QUERY");
        foreach (var group in studentsByGroups)
        {
            Console.WriteLine("Students in group: {0}", group.StudentGroup);
            foreach (var student in group.studentsInGroup)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("------------------------------------");
        }
        Console.WriteLine("\n");
        // ===============================================================


        //Problem 19. Grouped by GroupName extensions

        //Rewrite the previous using extension methods.
        // anagrams.GroupBy(w => w.Trim(), new AnagramEqualityComparer()); 

        var studentsByGroupsEXT = students.GroupBy(st => st.GroupNumber);

        Console.WriteLine("Students grouped by group numbers USING EXTENSION METHODS");
        foreach (var group in studentsByGroupsEXT)
        {
            Console.WriteLine("Students in group: {0}", group.Key);
            foreach (var student in group)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("------------------------------------");
        }
    }

    static void PrintStudents(Student[] students)
    {
        foreach (var st in students)
        {
            Console.WriteLine(st);
        }
        Console.WriteLine("\n");
    }
}