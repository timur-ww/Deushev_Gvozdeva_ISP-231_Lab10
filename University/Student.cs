public class Student : IPerson
{
    public string name { get; set; }
    public int age { get; set; }
    public string group { get; set; }

    public string GetDescription() => $"Студент {name}, {age} лет, группа: {group}";
}