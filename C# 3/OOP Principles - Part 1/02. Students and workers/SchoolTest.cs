using System;
using System.Collections.Generic;
using System.Linq;

using School;

//Define abstract class Human with first name and last name. 
//Define new class Student which is derived from Human and has new field – grade. 
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour()
//that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

class SchoolTest
{
    static void Main()
    {
        Student[] students = new Student[] { 
            new Student("Benjamin", "Valencia", 5),
            new Student("Iola", "Craft", 2),
            new Student("Jaime", "Mills", 4),
            new Student("Erin", "Whitley", 4),
            new Student("Wilma", "Conner", 6),
            new Student("Deborah", "Bauer", 2),
            new Student("Raya", "Blevins", 6),
            new Student("Shannon", "Summers", 2),
            new Student("Benedict", "Hopkins", 2),
            new Student("Willow", "Vaughn", 3)
        };

        Worker[] workers = new Worker[] { 
            new Worker("Halee", "Chandler", 289, 10),
            new Worker("Gannon", "Butler", 143, 8),
            new Worker("Blaine", "Guy", 764, 11),
            new Worker("Florence", "Marquez", 164, 8),
            new Worker("Iris", "Solis", 317, 6),
            new Worker("Portia", "Walton", 347, 9),
            new Worker("Jack", "Young", 249, 13),
            new Worker("Rama", "Guerrero", 825, 13),
            new Worker("Ramona", "Montoya", 701, 10),
            new Worker("Rudyard", "Kidd", 503, 16)
        };

        var studentsByGrade = from st in students
                              orderby st.Grade ascending
                              select st;

        var workersByMoneyPerHour = from w in workers
                                    orderby w.MoneyPerHour() ascending
                                    select w;

        List<Human> studentsAndWorkers = new List<Human>();
        studentsAndWorkers.AddRange(studentsByGrade);
        studentsAndWorkers.AddRange(workersByMoneyPerHour);

        var sortedStudentsAndWorkers = from h in studentsAndWorkers
                                       orderby h.FirstName, h.LastName ascending
                                       select h;


        Console.WriteLine("Students by grade: ");
        PrintHumans(studentsByGrade);

        Console.WriteLine("Workers by money per hour: ");
        PrintHumans(workersByMoneyPerHour);

        Console.WriteLine("Students and workers, sorted by first and last name: ");
        PrintHumans(sortedStudentsAndWorkers);
    }

    public static void PrintHumans<T> (IEnumerable<T> humans)
    {
        foreach (var h in humans)
        {
            Console.WriteLine(h.ToString());
        }
        Console.WriteLine();
    }
}