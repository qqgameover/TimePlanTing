using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class Course : SchoolClass
    {
        public Course(string courseName, Teacher courseTeacher) : base(courseName, courseTeacher, new List<Student>())
        {
        }
    }
}
