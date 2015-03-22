using System;

namespace School
{
    public class Discipline : ICommentable
    {
        private string name;
        private string comment;
        private int numberOfLectures;
        private int numberOfExercises;

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

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Number of Lectures");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Number of Excercises");
                }
                this.numberOfExercises = value;
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