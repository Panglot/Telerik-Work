namespace PathOfTheWarrior.Items
{
    using Interfaces;
using System.Windows.Media;

    public class Trophy : Item, IHasAvatar, INameable
    {

        private string description;
        public string Description { get { return description; } private set { this.description = value; } }

        public Trophy(string name, string description, ImageSource avatar) : base(name) { this.Description = description; this.Avatar = avatar; }

    }

}