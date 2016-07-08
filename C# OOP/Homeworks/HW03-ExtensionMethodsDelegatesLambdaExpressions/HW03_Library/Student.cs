using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_Library
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }


        public Student()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age = -1;
        }
        public Student(string first, string second, int age)
        {
            this.FirstName = first;
            this.LastName = second;
            this.Age = age;
        }


        public override string ToString()
        {
            return FirstName + "\n"+LastName+"\n"+Age;
        }
    }
}
