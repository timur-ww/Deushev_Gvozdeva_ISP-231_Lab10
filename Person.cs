class Person {
    public string? name { get; set; }
    public virtual void SayHello() {
        Console.WriteLine($"Привет, меня зовут {name}!!!!");
    }
}
