namespace War_arena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new();
            arena.AddUnit(new Warrior("Рагнар"));
            arena.AddUnit(new Mage("Гендальф"));
            arena.AddUnit(new Archer("Леголас"));
            arena.StartBattle();
        }
    }
}
