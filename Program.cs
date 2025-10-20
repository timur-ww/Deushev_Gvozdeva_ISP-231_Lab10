using System.Net.Http.Headers;

namespace Program {
    internal class Program
    {
        static void Main(string[] args)
        {

            // Шаг 1. Анонимные типы

            /*var monster = new {
                name = "Дракон",
                levek = 500,
                hp = 30_00,
                damage = 15_000,
                isBoss = true
            };
            Console.WriteLine(monster.name);

            var products = new[] {
                new{name = "Молоко", price = 100, category = "продукт"},
                new{name = "Ноутбук", price = 100_000, category = "электроника"}
            };

            foreach (var product in products) {
                Console.WriteLine($"{product.name} ({product.category}) - {product.price} руб");
            }

            // Шаг 2. Наследование

            Student student = new();
            student.name = "Ника";
            student.University = "ВФ Волгу";
            student.SayHello();
            Console.WriteLine($"Учится в: {student.University}");*/

            // Шаг 3. Переопределение методов (override)

            /*Student student1 = new();
            student1.name = "Тимур";
            student1.University = "ВФ Волгу";
            student1.SayHello();

            Person student2 = new();
            student2.name = "Ника";
            student2.SayHello();

            // Шаг 4. Ключевое слово base

            student1.SayHello();*/

            // Шаг 5. Абстрактные классы и методы

            /*Dog dog = new Dog { name = "Бобик" };
            Cat cat = new Cat { name = "Мурка" };

            dog.Info();
            dog.MakeSound();

            cat.Info();
            cat.MakeSound();*/

            // Шаг 6. Лямбды

            /*int Squeare(int x) {
                return x * x;
            }

            Console.WriteLine(Squeare(5));

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            Button button = new();
            button.OnClick += () => Console.WriteLine("Кнопка нажата!");
            button.Click();*/

            // Шаг 7. Интерфейсы

            /*List<ISound> sounds = new List<ISound> {
                new Bird(),
                new Phone()
            };

            foreach (var sound in sounds) {
                sound.MakeSound();
            }

            Book book = new Book { name = "Война и мир" };
            Console.WriteLine(book.name);*/

            // Шаг 8. Полиморфизм

            /*Animal[] animals = {
                new Dog {name = "Бобик"},
                new Cat {name = "Мурка"}
            };

            foreach (var animal in animals)
            {
                animal.Info();
                animal.MakeSound();
            }*/
        }
    }
}
