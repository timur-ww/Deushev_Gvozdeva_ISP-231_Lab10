namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1 — Анонимные типы

            /*var student = new { name = "Nika", age = 18, group = "ИСП-231" };

            Console.WriteLine($"Имя: {student.name}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group} \n");

            var students = new[]
            {
                new { name = "Nika", age = 18, group = "ИСП-231" },
                new { name = "Timur", age = 17, group = "ИСП-231" },
                new { name = "Ahmed", age = 17, group = "ИСП-231" },
                new { name = "Artem", age = 18, group = "ИСП-231" },
                new { name = "Timofey", age = 17, group = "ИСП-231(отчислен)" }
            }.ToList();

            foreach (var i in students)
            {
                Console.WriteLine($"Имя: {i.name}, Возраст: {i.age}, Группа: {i.group} \n");
            }*/

            // Задание 2 — Лямбда-выражения

            /*List<int> numbers = [];

            for (int i = 0; i <= 20; i++) numbers.Add(i);

            List<int> chet = numbers.FindAll(n => n % 2 == 0);

            List<int> cratTrem = numbers.FindAll(n => n % 3 == 0);

            Console.WriteLine($"Четные числа: {string.Join(", ", chet)} \n");

            Console.WriteLine($"Числа, кратные 3: {string.Join(", ", cratTrem)}");*/

            // Задание 3 — Интерфейсы

            /*List<IPrintable> printables = new List<IPrintable>
            {
                new Book("Грокаем алгоритмы", "Адитья Бхаргава", 2024),
                new Magazine("Forbes", "Бизнес")
            };

            foreach (var i in printables)
            {
                i.PrintInfo();
            }*/

            // Задание 4 — LINQ-запросы

            /*string[] cities =
            {
                "Волжский", "Волгоград", "Самарканд", "Москва", "Казань",
                "Грозный", "Сочи", "Санкт-Питербург", "Краснодар","Астрахань"
            };

            var res1 = cities.Where(city => city.StartsWith("К"));
            Console.WriteLine($"Города начинающиеся на К: {string.Join(", ", res1)} \n");

            var res2 = cities.OrderBy(city => city.Length);
            Console.WriteLine($"Города, отсортированные по длине названия: {string.Join(", ", res2)} \n");

            var res3 = cities.Where(city => city.Length > 6);
            Console.WriteLine($"Города длиной более 6 символов: {string.Join(", ", res3)} \n");*/
        }

        // Задание 5 — Асинхронное программирование

        /*static async Task Main(string[] args)
        {
            Console.WriteLine("Ждем данные...");

            Console.WriteLine($"Полученные данные: {await GetDataAsync()}!");
        }

        static async Task<int> GetDataAsync()
        {
            Console.WriteLine("Получаем данные...");
            await Task.Delay(2000);
            Console.WriteLine("Данные получены с сервера");
            
            return 812;
        }*/
    }
}
