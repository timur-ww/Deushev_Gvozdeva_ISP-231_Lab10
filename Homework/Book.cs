public class Book : IPrintable
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Книга: \"{title}\", Автор: {author}, Год издания: {year}");
    }
}