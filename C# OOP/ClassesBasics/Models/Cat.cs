using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat :Mammal, ISomething
    {
        public Cat(string name):base(name)
        {

        }
    }
}
