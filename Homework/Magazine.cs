public class Magazine : IPrintable 
{
    public string name { get; set; }
    public string category { get; set; }

    public Magazine(string name, string category)
    {
        this.name = name;
        this.category = category;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Журнал: \"{name}\", Категория: {category}");
    }
}