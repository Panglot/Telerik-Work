namespace PathOfTheWarrior.Items
{
    using Interfaces;

    public class Armor : Item, IHealthUp, IHasAvatar, INameable
    {
        private int bonusHealth;
        public int BonusHealth { get { return bonusHealth; } set { this.bonusHealth = value; } }

        public Armor() { }
        public Armor(int bonusHP) { this.BonusHealth = bonusHP; }
        public Armor(string Name, int bonusHP) : base(Name) { this.BonusHealth = bonusHP; }


        public void AddHealth(ICharacter character)
        {
            character.HP += BonusHealth;
        }
    }

}