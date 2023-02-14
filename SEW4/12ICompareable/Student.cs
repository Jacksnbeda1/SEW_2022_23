using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12IComparable
{
    internal class Student : IComparable<Student>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public Student(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public int CompareTo(Student? other)
        {
            return this.LastName.CompareTo(other.LastName);         //wenn kleiner dann -1, wenn gleich dann 0, wenn größer dann +1
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
