// Шаг 13. Лямбды с несколькими параметрами

namespace lambda
{
    internal class Program
    {
        delegate int MathOperation(int a, int b);
        static void Main(string[] args)
        {
            /*Func<int, int, int> sum = (a, b) => a + b;
            Console.WriteLine(sum(3, 7));*/

            /*Func<int, string> numberToWord = num =>
            {
                switch (num)
                {
                    case 1: return "один";
                    case 2: return "два";
                    default: return "много";
                }
            };

            Console.WriteLine(numberToWord(2));*/

            /*MathOperation add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));*/
         }
    }
}
