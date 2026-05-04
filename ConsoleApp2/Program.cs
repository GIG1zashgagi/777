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
        
        static int CountVowelsFixed(string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;

            int count = 0;

            foreach (char c in text)
            {
                char lowerChar = char.ToLower(c);

                if (char.IsLetter(c))
                {
                    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' ||
                        lowerChar == 'o' || lowerChar == 'u')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

      
    }
}
