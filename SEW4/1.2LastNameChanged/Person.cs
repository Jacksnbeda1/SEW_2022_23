using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2LastNameChanged
{
    internal class Person
    {
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public void LastNameChanged(Person p)
        {
            p.LastNameChanged(this);
        }
       
        if (this.LastNameChanged != null)
        {
            this.LastNameChanged(this, EventArgs.Empty);
        }

        }

    }
}
