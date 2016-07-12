using PathOfTheWarrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PathOfTheWarrior.Items
{
    class HealthPotion : Consumable, IHasAvatar
    {

        public HealthPotion(int bonusStat, ImageSource avatar)
            : base(bonusStat, avatar) { }

        public HealthPotion() { }

        public override void DrinkPotion(ICharacter character)
        {
            character.HP += this.BonusStat;
        }

        
    }
}
