namespace PathOfTheWarrior.Items
{
    using Interfaces;
    public class Weapon : Item, IDamageUp, IHasAvatar
    {
        private int bonusDamage;
        public int BonusDamage { get { return bonusDamage; } set { this.bonusDamage = value; } }

        public Weapon() { }
        public Weapon(string Name, int dmg) : base(Name) { this.BonusDamage = dmg; }

        public void AddDamage(ICharacter character)
        {
            character.DMG += BonusDamage;
        }
    }
}