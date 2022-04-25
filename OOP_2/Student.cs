using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    class Student
    {
        string name;
        string personalID;

        public Student() //:this("unknow", "unknow")
        {
            this.name = "unknow";
            this.personalID = "unknow";
        }

        public Student(string name, string personalID)
        {
            this.name = name;
            this.personalID = personalID;
        }


        public override string ToString()
        {
            return String.Format("{0,-5}: {1,-20}, {2,-15}: {3,-20}  ",
                nameof(this.name), this.name,
                nameof(this.personalID), this.personalID);
        }
    }
}
