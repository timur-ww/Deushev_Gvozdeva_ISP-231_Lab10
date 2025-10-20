public class Teacher : IPerson
{
    public string name { get; set; }
    public string department { get; set; }

    public string GetDescription() => $"Преподователь {name}, кафедра: {department}";
}