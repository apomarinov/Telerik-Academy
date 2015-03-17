using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string FacultyNumber;
        public string Phone;
        public List<int> Marks;
        public int GroupNumber;

        public Student(string firstName, string lastName, string email, string facultyNumber, string phone, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }

        public string MarksToString()
        {
            return string.Join(", ", this.Marks.ToArray());
        }

        public override string ToString()
        {
            return String.Format("Names: {0} Email: {1} FN: {2} Tel: {3} Group: {4}", (
                this.FirstName + " " + this.LastName).PadRight(17, ' '), 
                this.Email.PadRight(30, ' '),
                this.FacultyNumber.PadRight(6, ' '),
                this.Phone.PadRight(15, ' '),
                this.GroupNumber);
        }
    }

    public class Group 
    {
        public int GroupNumber;
        public string DepartmentName;

        public Group(int gn, string dn)
        {
            this.GroupNumber = gn;
            this.DepartmentName = dn;
        }
    }
}
