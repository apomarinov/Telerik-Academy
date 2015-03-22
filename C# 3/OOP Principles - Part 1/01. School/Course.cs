using System;
using System.Collections.Generic;

namespace School
{
    public class Course : ICommentable
    {
        private List<Teacher> teachers;
        private int uniqueTextIdentifier;
        private string comment;

        public List<Teacher> Teachers
        {
            get { return new List<Teacher>(this.teachers); }
        }

        public int UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Unique Text Identifier");
                }
                this.uniqueTextIdentifier = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inavlid Comment!");
                }
                this.comment = value;
            }
        }
    }
}