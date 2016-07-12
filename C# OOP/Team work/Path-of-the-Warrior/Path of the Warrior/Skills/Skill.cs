namespace PathOfTheWarrior.Skills
{
    using System.Windows.Media;
    using Interfaces;

    public abstract class Skill: ISkill, IHasAvatar, INameable
    {
        public ImageSource Avatar { get; set; }


        protected string name;
        protected int hP;
        public string Name { get; set; }
        public int HP { get; set; }

        public abstract int Calculate();

    }
}
