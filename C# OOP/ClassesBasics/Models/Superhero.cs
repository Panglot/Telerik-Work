using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Superhero
    {
        private string name;

        public Superhero(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length<2)
                {
                    throw new ArgumentException("The name is too short. Please write longer name.");
                }
                this.Name = value;
            }
        }
        
    }
}
