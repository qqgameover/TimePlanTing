using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class School
    {
        public List<SchoolClass> Classes { get; private set; }
        public List<Student> StudentList { get; private set; }
        public List<Course> Courses { get; private set; }
        public List<Teacher> Teachers { get; private set; }

        public School(List<SchoolClass> classes, List<Course> courses, List<Teacher> teachers)
        {
            Classes = classes;
            StudentList = new List<Student>();
            Courses = courses;
            Teachers = teachers;
            AddStudentsToList();
        }

        private void AddStudentsToList()
        {
            foreach (var s in Classes.SelectMany(c => c.ClassList))
            {
                StudentList.Add(s);
            }
        }

        public void HandleCommand(string command)
        {
            var splitCommand = command.Split(" ");
            if (splitCommand[0].Contains("vis") && splitCommand[1].Contains("klasse"))
            {
                foreach (var c in Classes)
                {
                    if(c.ClassName != splitCommand[2]) continue;
                    Console.WriteLine($"Lærer: {c.Teacher.Name}");
                    Console.Write($"Elever: \n");
                    foreach (var p in c.ClassList)
                    {
                        Console.WriteLine(p.Name);
                    }
                }
            }

            if (splitCommand[0].Contains("vis") && splitCommand[1].Contains("fag"))
            {
                foreach (var c in Courses)
                {
                    if(c.CourseName != splitCommand[2]) continue;
                    Console.WriteLine($"Lærer: {c.CourseTeacher.Name}");
                    Console.Write($"Elever: \n");
                    foreach (var p in c.StudentList)
                    {
                        Console.WriteLine(p.Name);
                    }
                }
            }

            if (splitCommand[0].Contains("p"))
            {
                foreach (var s in StudentList)
                {
                    if(s.Name != splitCommand[1] + " " + splitCommand[2]) continue;
                    foreach (var course in Courses)
                    {
                        if(course.CourseName != splitCommand[3]) continue;
                        course.AddStudentToCourse(s);
                    }
                }
            }
        }
    }
}
