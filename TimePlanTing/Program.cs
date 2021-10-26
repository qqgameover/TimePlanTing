using System;
using System.Collections.Generic;
using System.Linq;

namespace TimePlanTing
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher1 = new Teacher("Elizabeth nightmare");
            var teacher2 = new Teacher("Tvilsomme Ole");
            var teacherList = new List<Teacher>
            {
                teacher1,
                teacher2,
            };
            var classList = new List<SchoolClass>
            {
                new ("1A", teacher1, new List<Student>{
                    new ("Kasper L"),
                    new ("Ola Jens"),
                    new ("Ragnar J"),
                    new ("JegKlarerIkkeFinnePaaNavn"),
                }),
                new ("1B", teacher2, new List<Student>{
                    new ("Repsak L"),
                    new ("Jens Ole"),
                    new ("Just Jacobsen"),
                    new ("Mari M"),
                })
            };
            var courseList = new List<Course>
            {
                new ("Matte", teacher1),
                new ("Engelsk", teacher1),
                new ("Ny norsk", teacher2),
                new ("Gym", teacher2)
            }; 
            AddDummyData(courseList, classList);
            var school = new School(classList, courseList, teacherList);
            Console.WriteLine("Skriv vis k/f => navn for å se en klasse eller et fag.");
            Console.WriteLine("Skriv p => navn => fag for å melde noen på et fag.");
            while (true)
            {
                var c = Console.ReadLine();
                if (c == "") break;
                school.HandleCommand(c);
            }
        }

        private static void AddDummyData(List<Course> courseList, List<SchoolClass> classList)
        {
            courseList[0].AddStudentToClass(classList[0].ClassList[0]);
            courseList[1].AddStudentToClass(classList[0].ClassList[0]);
            courseList[3].AddStudentToClass(classList[0].ClassList[0]);

            courseList[0].AddStudentToClass(classList[1].ClassList[0]);
            courseList[1].AddStudentToClass(classList[1].ClassList[0]);
            courseList[3].AddStudentToClass(classList[1].ClassList[0]);

            courseList[0].AddStudentToClass(classList[1].ClassList[1]);
            courseList[1].AddStudentToClass(classList[1].ClassList[1]);
            courseList[3].AddStudentToClass(classList[1].ClassList[1]);
        }
    }
}
