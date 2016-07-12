namespace PathOfTheWarrior.Interfaces
{
    public interface IDamageUp
    {
        int BonusDamage { get; set; }

        void AddDamage(ICharacter character);
    }
}
