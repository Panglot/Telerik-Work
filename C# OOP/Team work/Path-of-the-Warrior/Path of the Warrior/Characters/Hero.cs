namespace PathOfTheWarrior.Characters
{
    using Interfaces;
    using Items;
    using System.Collections.Generic;

    public class Hero : Character, INameable, IHasAvatar, ICharacter
    {
        private List<Item> inventory;
        public List<Item> Inventory { get { return inventory; } set { this.inventory = value; } }

        public Hero(int hp) 
        {
            this.HP = hp;
            this.Inventory = new List<Item>();
        }
        public Hero(int hp, int dmg, List<Item> inventory) :base(hp,dmg)
        {
            this.Inventory = new List<Item>();
        }

    }
}
