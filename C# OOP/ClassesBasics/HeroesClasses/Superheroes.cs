using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesClasses
{
    class Superheroes
    {
        static void Main(string[] args)
        {

            var hero = new Superhero("Karnobatman");
            
            Console.WriteLine(hero.Name);
        }

    }
}
