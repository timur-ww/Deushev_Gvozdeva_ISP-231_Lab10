public class Arena
{
    private List<IUnit> _units = new();

    public void AddUnit(IUnit unit)
    {
        _units.Add(unit);
    }

    public void StartBattle()
    {
        Console.WriteLine("Битва началась!");
        foreach (var attacker in _units)
        {
            foreach (var defender in _units)
            {
                if (attacker != defender)
                {
                    attacker.Attack(defender);
                }
            }
        }
    }
}