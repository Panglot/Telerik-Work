namespace PathOfTheWarrior.Skills
{
    using Interfaces;

    class PrecisionStrike : Skill, IHasAvatar, INameable
    {
        public PrecisionStrike(string name, int damage)
        {
            this.Name = name;
            this.HP = damage;
        }
        public PrecisionStrike() { }

        public override int Calculate()
        {
            return HP;
        }
    }
}
