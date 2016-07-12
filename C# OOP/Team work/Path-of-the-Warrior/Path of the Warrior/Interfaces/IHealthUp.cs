namespace PathOfTheWarrior.Interfaces
{
    public interface IHealthUp
    {
        int BonusHealth { get; set; }

        void AddHealth(ICharacter character);
    }
}
