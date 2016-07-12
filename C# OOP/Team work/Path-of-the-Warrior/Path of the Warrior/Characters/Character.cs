namespace PathOfTheWarrior.Characters
{
    using Interfaces;
    using System;
    using System.Windows.Media;

    public class Character : INameable, IHasAvatar, ICharacter
    {
        private string name;
        private int hp;
        private int dmg;
        private ImageSource avatar;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The name cannot be null or empty");
                }
                this.name = value;
            }
        }
        public int HP { get { return hp; } set { this.hp = value; } }
        public int DMG { get { return dmg; } set { this.dmg = value; } }
        public ImageSource Avatar { get { return avatar; } set { this.avatar = value; } }

        public Character() { }

        public Character(int hp, int dmg)
        {
            this.HP = hp;
            this.DMG = dmg;
        }

        public Character(string name, int hp, int dmg)
        {
            this.Name = name;
            this.HP = hp;
            this.DMG = dmg;
        }

    }

}
