using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class Course
    {
        public string CourseName { get; private set; }
        public List<Student> StudentList { get; private set; }
        public Teacher CourseTeacher { get; private set; }

        public Course(string courseName, Teacher courseTeacher)
        {
            CourseName = courseName;
            StudentList = new List<Student>();
            CourseTeacher = courseTeacher;
        }

        public void AddStudentToCourse(Student s)
        {
            StudentList.Add(s);
        }
    }
}
