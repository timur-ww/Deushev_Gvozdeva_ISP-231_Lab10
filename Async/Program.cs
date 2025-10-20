using System.Security.AccessControl;

namespace Async {
    internal class Program {

        // Шаг 9. Асинхронное программирование

        /*static async Task BoilWaterAsync() {
            Console.WriteLine("2. Кипятим воду (ждем 3 секунды)...");
            await Task.Delay(3000);
            Console.WriteLine("...вода закипела!!!!!!!!!!!!");
        }

        static async Task Main() {
            Console.WriteLine("1. Включили чайник...");

            Task boiltask = BoilWaterAsync();
                Task sliceTask = SliceLemonAsync();

            await Task.WhenAll(boiltask, sliceTask);

            Console.WriteLine("4. Завариваем чай с лимоном!");
        }

        static async Task SliceLemonAsync() {
            Console.WriteLine("3. Режем лимон (ждем 2 секунды)...");
            await Task.Delay(2000);
            Console.WriteLine("...лимон порезан!");
        }*/

        // Шаг 12. Асинхронно варим ужин

        /*static async Task Main()
        {
            Console.WriteLine("Начинаем готовить ужин...");
            await CookDinnerAsync();
            Console.WriteLine("Ужин готов");
        }
        public static async Task<string> MakeSoupAsync() {
            Console.WriteLine("Начали варить суп...");
            await Task.Delay(3000);
            return "Суп";
        }

        public static async Task<string> MakeSaladAsync()
        {
            Console.WriteLine("Начали резать салат...");
            await Task.Delay(1000);
            return "Салат";
        }

        public static async Task CookDinnerAsync()
        {
            Task<string> soupTask = MakeSoupAsync();
            Task<string> saladTask = MakeSaladAsync();

            string soup = await soupTask;
            string salad = await saladTask;

            Console.WriteLine($"Готово: {soup} и {salad}");
        }*/
    }
}
