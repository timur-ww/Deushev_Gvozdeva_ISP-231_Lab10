abstract class Animal {
    public string? name { get; set; }

    public abstract void MakeSound();

    public void Info() => Console.WriteLine($"Животное: {name}");
}