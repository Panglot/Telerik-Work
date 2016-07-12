using PathOfTheWarrior.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PathOfTheWarrior.Items
{
    class DamagePotion : Consumable, IHasAvatar
    {

        public DamagePotion(int bonusStat, ImageSource avatar)
            : base(bonusStat, avatar) { }

        public DamagePotion() { }

        public override void DrinkPotion(ICharacter character)
        {
            character.DMG += this.BonusStat;
        }

    }
}