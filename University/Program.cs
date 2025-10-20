namespace University
{
    internal class Program
    {
        static async Task Main()
        {
            var students = await LoadStudentsAsync();

            var teachers = new List<Teacher>
            {
                new Teacher {name = "Денис Александрович", department = "Информатика"},
                new Teacher {name = "Ольга Викторовна", department = "Математика"},
                new Teacher {name = "Лариса Васильевна", department = "Информатика"}
            };

            var people = new List<IPerson>();
            people.AddRange(students);
            people.AddRange(teachers);

            var res1 = students.Where(s => s.age > 20).ToList();
            Console.WriteLine($"Студенты старше 20 лет: ");
            foreach (var i in res1) Console.WriteLine(i.GetDescription());

            var res2 = teachers.Where(t => t.department == "Информатика").ToList();
            Console.WriteLine($"\nПреподователи с кафедры информатики: ");
            foreach (var i in res2) Console.WriteLine(i.GetDescription());

            /*Console.WriteLine("Все люди: ");
            foreach (var i in people) Console.WriteLine(i.GetDescription());*/
        }

        static async Task<List<Student>> LoadStudentsAsync()
        {
            Console.WriteLine("Загрузка студентов... \n");
            await Task.Delay(3000);
            Console.WriteLine("Студенты загружены \n");

            return new List<Student>()
            {
                new Student{name = "Ника", age = 20, group = "ИСП - 231" },
                new Student{name = "Тимур", age = 21, group = "ИСП - 231"},
                new Student {name = "Ахмед", age = 33, group = "ИСП - 231"},
                new Student {name = "Тимофей", age = 11, group = "Отчислен"}
            };
        }
    }
}
