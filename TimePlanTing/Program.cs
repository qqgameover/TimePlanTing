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
            var studentListA1 = new List<Student>
            {
                new ("Kasper L"),
                new ("Ola Jens"),
                new ("Ragnar J"),
                new ("JegKlarerIkkeFinnePaaNavn"),
            };
            var studentListB1 = new List<Student>
            {
                new ("Repsak L"),
                new ("Jens Ole"),
                new ("Just Jacobsen"),
                new ("Mari M"),
            };
            var classList = new List<SchoolClass>
            {
                new ("1A", teacher1, studentListA1),
                new ("1B", teacher2, studentListB1)
            };
            var courseList = new List<Course>
            {
                new Course("Matte", teacher1),
                new Course("Engelsk", teacher1),
                new Course("Ny norsk", teacher2),
                new Course("Gym", teacher2)
            };
            var school = new School(classList, courseList, teacherList);
            while (true)
            {
                var c = Console.ReadLine();
                if (c == "") break;
                school.HandleCommand(c);
            }
        }
    }
}
