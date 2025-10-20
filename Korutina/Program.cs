using System.Collections.Generic;

namespace Korutina {
    internal class Program {
        /*static void Main(string[] args) {
            foreach (int number in GenerateNumbers()) {
                Console.WriteLine($"Получено число: {number}");
            }
        } 
        static IEnumerable<int> GenerateNumbers() {
            Console.WriteLine("Начинаем генерацию... ");
            yield return 1;

            Console.WriteLine("Пауза...");
            yield return 2;

            Console.WriteLine("И еще раз...");
            yield return 3;

            Console.WriteLine("Готово!");
                
        }*/

        // Шаг 14. Корутина в действии

        /*static IEnumerable<string> WaitCoroutine()
        {
            yield return "Ждем... 1 секунда";
            yield return "Ждем... 2 секунды";
        }

        static void Main(string[] args)
        {
            foreach (var step in WaitCoroutine())
            {
                Console.WriteLine(step);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Готово!");
        }*/

        /*static async Task Main()
        {
            Console.WriteLine("Ждем... 2 секунды");
            await Task.Delay(2000);
            Console.WriteLine("Готово!");
        }*/
    }
}
