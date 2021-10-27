using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class Session
    {
        public SchoolClass Course { get; private set; }
        public Teacher Teacher { get; private set; }
        public List<Student> Students { get; private set; }
        public Date TimeSlot { get; private set; }

        public Session(SchoolClass course, Teacher teacher, List<Student> students, Date timeSlot)
        {
            Course = course;
            Teacher = teacher;
            Students = students;
            TimeSlot = timeSlot;
        }
    }
}
