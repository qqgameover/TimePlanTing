using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class SchoolClass
    {
        public List<Student> ClassList { get; private set; }
        public string ClassName { get; private set; }
        public Teacher Teacher { get; private set; }

        public SchoolClass(string cName,Teacher t, List<Student> initClassList)
        {
            ClassList = new List<Student>(initClassList);
            Teacher = t;
            ClassName = cName;
        }

        public void AddStudentToClass(Student p)
        {
            ClassList.Add(p);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Lærer: {Teacher.Name}");
            Console.Write($"Elever: \n");
            foreach (var p in ClassList)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
