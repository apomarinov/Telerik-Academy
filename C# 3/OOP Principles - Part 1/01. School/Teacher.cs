using System;
using System.Collections.Generic;

namespace School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public List<Discipline> Disciplines
        {
            get { return new List<Discipline>(this.disciplines); }
        }
    }
}