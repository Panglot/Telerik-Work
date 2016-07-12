using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathOfTheWarrior.Items
{
    abstract class PotionCreator
    {
        public abstract Consumable FactoryMethod();
    }
}
