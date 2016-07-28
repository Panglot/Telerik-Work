using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string Name { get; set; }

        public Student()
        {

        }
        public Student(string name)
        {
            this.Name = name;
        }
    }
}
