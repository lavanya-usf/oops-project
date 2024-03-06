using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_project
{
    class GraduateStudent: Student, BestPractices
    {
        public string Study()
        {
            // Implementation of the Study method for GraduateStudent
            return "Studying as a graduate student.";
        }

        // You also need to provide an implementation for the Rest method
        public string Rest()
        {
            // Implementation of the Rest method for GraduateStudent
            return "Taking a break as a graduate student.";
        }
    }
}
