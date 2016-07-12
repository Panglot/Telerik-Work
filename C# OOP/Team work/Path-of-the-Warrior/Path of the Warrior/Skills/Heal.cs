namespace PathOfTheWarrior.Skills
{
    using Characters;
    using Interfaces;

    class Heal : Skill, IHasAvatar, INameable
    {
        public Heal(string name, int hp)
        {
            this.Name = name;
            this.HP = hp;
        }

        public Heal() { }
        public override int Calculate()
        {
            return HP;
        }
        public Character RestoreHealth(Character character)
        {
            character.HP += this.Calculate();
            return character;
        }
    }
}
