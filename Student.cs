using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_project
{
    internal class Student : Person
    {
        public string studentNumber;
        private string SSN;

        public Student()
        {
            studentNumber = "U24723610";
            SSN = string.Empty;
        }

        public string getSSN()
        {
            return SSN;
        }

        public void setSSN(string value)
        {
            SSN = value;
        }
    }
}
