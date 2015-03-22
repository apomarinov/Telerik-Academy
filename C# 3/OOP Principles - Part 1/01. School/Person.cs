using System;

namespace School
{
    public class Person : ICommentable
    {
        private string name;
        private string comment;

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