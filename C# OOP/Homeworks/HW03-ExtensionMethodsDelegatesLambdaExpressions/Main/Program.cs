using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW03_Library;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student[] {
               new Student ("Ivan", "Petrov", 10),
               new Student ("Kiro", "Ivanov", 22),
               new Student ("Pesho", "Troplev", 50),
               new Student ("Dobromir", "Bogatev", 22)

            };

            var studentFiltered = student.Where(item => item.Age >= 18 && item.Age <= 24).Select(item => item).ToList();

            foreach (var item in studentFiltered)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
