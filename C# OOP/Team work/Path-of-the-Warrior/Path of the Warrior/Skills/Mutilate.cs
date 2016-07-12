namespace PathOfTheWarrior.Skills
{
    using Interfaces;
    using System;

    class Mutilate : Skill, IHasAvatar, INameable
    {

        public Mutilate() { }
        public Mutilate(string name, int damage)
        {
            this.Name = name;
            this.HP = damage;
        }

        public override int Calculate()
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 100);
            if (chance < 50)
            {
                return 0;
            }
            else
            {
                return HP;
            }
        }
    }
}
