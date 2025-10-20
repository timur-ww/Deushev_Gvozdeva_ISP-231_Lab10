using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace LINQ {
    internal class Program {
        static void Main(string[] args) {
            /*List<int> numbers = new List<int> { 5, 2, 9, 4, 7, 3, 8, 23, 45, 12, 34, 13, 98, 67, 56, 99 };

            List<int> evenNumbers = new List<int>();

            foreach (var num in numbers) {
                if (num % 2 == 0)
                    evenNumbers.Add(num);
            }

            List<int> multiplied = new List<int>();
            foreach (var num in evenNumbers) {
                multiplied.Add(num * 10);
            }

            multiplied.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine("Результат: (без LINQ): ");
            foreach (var num in multiplied) {
                Console.WriteLine(num);
            }

            var res = numbers
                .Where(n => n % 2 == 0)
                .Select(n => n * 10)
                .OrderByDescending(n => n);

            // без LINQ
            List<string> names = new List<string> { "Анна", "Иван", "Мария", "Петр" };

            List<string> longNames = new List<string>();

            foreach (var name in names) {
                if (name.Length > 4)
                    longNames.Add(name);
            }

            foreach (var name in longNames) {
                Console.WriteLine(name);
            }

            // с LINQ
            var linqLongName = names.Where(name => name.Length > 4);

            foreach (var name in linqLongName) {
                Console.WriteLine(name);
            }

            // без LINQ
            List<int> nums = new List<int> { 10, 5, 20, 3 };

            int min = nums[0];

            foreach (var num in nums) {
                if (num < min)
                    min = num;
            }

            Console.WriteLine($"\nМинимальное число (без LINQ): {min}");

            List<int> nums = new List<int> { 10, 5, 20, 3 };

            // с LINQ
            int linqMin = nums.Min();
            Console.WriteLine($"Минимальное число (с LINQ): {linqMin}");*/

            /*List<int> numbers = new List<int> { 1, 2, 3, 4 };

            // без LINQ 

            List<int> squares = new List<int>();

            foreach (var num in numbers) {
                squares.Add(num * num);
            }

            Console.WriteLine("\nКвадрат чисел (без LINQ): ");
            Console.WriteLine(string.Join(", ", squares));

            // с LINQ
            var linqSquares = numbers.Select(n => n * n);
            Console.WriteLine("Квадрат чисел (с LINQ): ");
            Console.WriteLine(string.Join(", ", linqSquares));*/

            /*List<Student> students = new() {
                new Student {name = "Андрей", Score = 90},
                new Student {name = "Вика", Score = 78},
                new Student {name = "Денис", Score = 85},
                new Student {name = "Лена", Score = 95},
                new Student {name = "Олег", Score = 65}
            };

            List<Student> goodStudents = new List<Student>();
            int total = 0;

            foreach (var s in students) {
                total += s.Score;
                if (s.Score > 80)
                    goodStudents.Add(s);
            }

            goodStudents.Sort((a, b) => a.name.CompareTo(b.name));

            Console.WriteLine("Студенты с баллом выше 80");

            foreach (var s in goodStudents) {
                Console.WriteLine($"{s.name} - {s.Score}");
            }

            Console.WriteLine($"Срдений балл: {(double)total / students.Count:F1}");*/


           /* List<Student> students = new() {
                new Student {name = "Андрей", Score = 90},
                new Student {name = "Вика", Score = 78},
                new Student {name = "Денис", Score = 85},
                new Student {name = "Лена", Score = 95},
                new Student {name = "Олег", Score = 65}
            };

            var goodStudents = students
                .Where(s => s.Score > 80)
                .OrderBy(s => s.name);

            var averageScore = students.Average(s => s.Score);

            Console.WriteLine("Студенты с баллом > 80: ");

            foreach (var s in goodStudents)
                Console.WriteLine($"{s.name} - {s.Score}");

            Console.WriteLine($"Средний балл: {averageScore:F1}");*/
        }
    }
}
