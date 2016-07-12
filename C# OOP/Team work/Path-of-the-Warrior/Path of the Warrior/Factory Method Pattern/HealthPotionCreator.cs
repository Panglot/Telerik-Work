using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathOfTheWarrior.Items
{
     class HealthPotionCreator : PotionCreator
    {
        public override Consumable FactoryMethod()
        {
            return new HealthPotion();
        }
    }
}
