﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

class StudentsAge
{
    static void Main()
    {
        var students = new[] {
            new {FirstName = PadName("Amos"), LastName = PadName("Conway"), Age = 26},
            new {FirstName = PadName("Calista"), LastName = PadName("Knowles"), Age = 20},
            new {FirstName = PadName("Samson"), LastName = PadName("Avila"), Age = 25},
            new {FirstName = PadName("Samantha"), LastName = PadName("Burt"), Age = 19},
            new {FirstName = PadName("Carl"), LastName = PadName("Bass"), Age = 30},
            new {FirstName = PadName("Vanna"), LastName = PadName("Pennington"), Age = 21},
            new {FirstName = PadName("Alexander"), LastName = PadName("Powers"), Age = 27},
            new {FirstName = PadName("Charles"), LastName = PadName("Guerrero"), Age = 28},
            new {FirstName = PadName("Clinton"), LastName = PadName("Osborn"), Age = 21},
            new {FirstName = PadName("Debra"), LastName = PadName("Gomez"), Age = 19},
            new {FirstName = PadName("Judith"), LastName = PadName("Hayes"), Age = 16},
            new {FirstName = PadName("Jonas"), LastName = PadName("Schmidt"), Age = 28},
            new {FirstName = PadName("Sheila"), LastName = PadName("Charles"), Age = 22},
            new {FirstName = PadName("Nichole"), LastName = PadName("Benton"), Age = 15}
            };

        var selectedStudents = from student in students
                               where student.Age >= 18 && student.Age <= 24
                               select student;

        foreach (var st in selectedStudents)
        {
            Console.WriteLine(st);
        }
    }

    static string PadName(string name)
    {
        return name.PadRight(10, ' ');
    }
}