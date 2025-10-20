class Student : Person {
    public string? University { get; set; }
    public override void SayHello() {
        base.SayHello();

        Console.WriteLine($"Я учусь в {University}");
    }
}