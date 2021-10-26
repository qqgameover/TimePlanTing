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
        public Session[,] Timetable { get; private set; }
        //mandag 1-5, tirsdag 1-5 onsdag 1-5.
        public string[] DayArray;
        public int[] TimeArray;
        public School(List<SchoolClass> classes, List<Course> courses, List<Teacher> teachers)
        {
            Classes = classes;
            StudentList = new List<Student>();
            Courses = courses;
            Teachers = teachers;
            AddStudentsToList();
            Timetable = new Session[5, 5];
            DayArray = new []{"Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag"};
            TimeArray = new[] {0830, 1000, 1215, 1300, 1400};
        }

        public void FillTimeTable()
        {
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
            if (splitCommand[0].Contains("vis") && splitCommand[1].Contains("k"))
            {
                foreach (var c in Classes)
                {
                    if(c.ClassName != splitCommand[2]) continue;
                    c.PrintInfo();
                }
            }

            if (splitCommand[0].Contains("vis") && splitCommand[1].Contains("f"))
            {
                foreach (var c in Courses.Where(c => c.ClassName == splitCommand[2]))
                {
                    c.PrintInfo();
                }
            }

            if (splitCommand[0].Contains("p"))
            {
                foreach (var s in StudentList)
                {
                    if(s.Name != splitCommand[1] + " " + splitCommand[2]) continue;
                    foreach (var c in Courses.Where(c => c.ClassName == splitCommand[3]))
                    {
                        c.AddStudentToClass(s);
                    }
                }
            }
        }
    }
}
