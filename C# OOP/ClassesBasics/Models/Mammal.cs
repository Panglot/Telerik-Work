using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Mammal:ISomething
    {
        private string name;

        public Mammal(string name)
        {
            this.name = name;
        }

        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Mammal Moving"); 
        }

        public void Something()
        {
            Console.WriteLine("Mammal Something");
        }

        public void Talk()
        {
            Console.WriteLine("Mammal Talking");
        }
    }

    public interface ISomething
    {
         void Move();
         void Talk();
        void Something();



    }
}
