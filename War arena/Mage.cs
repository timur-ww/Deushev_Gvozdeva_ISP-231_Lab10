public class Mage : IUnit
{
    public string Name { get; private set; }
    public int Health { get; private set; }

    public Mage(string name)
    {
        Name = name;
        Health = 100;
    }

    public void Attack(IUnit target)
    {
        Console.WriteLine($"{Name} кастует заклинание {target.Name}! \n");
    }
}