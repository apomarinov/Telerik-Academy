using System;

namespace School
{
    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Grade");
                }
                this.grade = value;
            }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(" Grade: {0}", this.grade);
        }
    }
}