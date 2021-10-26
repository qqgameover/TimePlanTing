using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class Student : Person
    {
        public SchoolClass SchoolClass { get; private set; }

        public Student(string name) : base(name)
        {
        }

        public void JoinClass(SchoolClass c)
        {
            SchoolClass = c;
        }
    }
}
