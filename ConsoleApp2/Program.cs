using System;

namespace FibonacciDebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления чисел Фибоначчи");
            Console.Write("Введите количество чисел для вывода: ");

            string input = Console.ReadLine();
            int count;

            if (!int.TryParse(input, out count))
            {
                Console.WriteLine("Ошибка: введите целое число!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"\nПервые {count} чисел Фибоначчи:");
            PrintFibonacci(count);

            Console.WriteLine("\n\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}