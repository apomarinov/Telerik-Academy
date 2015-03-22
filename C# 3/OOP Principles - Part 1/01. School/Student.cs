using System;

namespace School
{
    public class Student : Person
    {
        private int uniqueClassNumber;

        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Unique Class Number");
                }
                this.uniqueClassNumber = value;
            }
        }
    }
}