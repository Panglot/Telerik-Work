using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathOfTheWarrior.Items
{
     class DamagePotionCreator : PotionCreator
    {
        public override Consumable FactoryMethod()
        {
            return new DamagePotion();
        }
    }
}
