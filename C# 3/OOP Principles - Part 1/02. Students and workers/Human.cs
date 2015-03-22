using System;
using System.Collections.Generic;

namespace School
{
    public abstract class Human 
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inavlid First Name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inavlid Last Name!");
                }
                this.lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("First Name: {0} Last Name: {1}", this.firstName.PadRight(10, ' '), this.lastName.PadRight(10, ' '));
        }
    }
}