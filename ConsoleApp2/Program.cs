using System;
using System.Text;

namespace LettersDebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анализатор гласных букв\n");
            Console.Write("Введите текст для анализа: ");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Вы не ввели текст!");
                Console.ReadKey();
                return;
            }

            int correctCount = CountVowelsFixed(input);
            Console.WriteLine($"Результат (исправленный): {correctCount} гласных");

            AnalyzeText(input);

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

    }
}
