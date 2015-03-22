using System;
using System.Collections.Generic;

namespace School 
{
    public class School
    {
        private List<Course> courses;
        private string name;

        public List<Course> Courses
        {
            get { return new List<Course>(this.courses); }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inavlid Name!");
                }
                this.name = value;
            }
        }
    }
}