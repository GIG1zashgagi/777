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
        static void AnalyzeText(string text)
        {
            Console.WriteLine("\n\nДетальный анализ каждого символа:");
            Console.WriteLine(new string('=', 60));
            Console.WriteLine($"{"Индекс",-8} {"Символ",-12} {"Тип",-20} {"Гласная",-10}");
            Console.WriteLine(new string('=', 60));

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                string type = char.IsLetter(c) ? "Буква" : (char.IsDigit(c) ? "Цифра" : "Знак");
                string isVowel = IsVowel(c) ? "Да" : "Нет";

                Console.WriteLine($"{i,-8} '{c}',-12 {type,-20} {isVowel,-10}");
            }

            Console.WriteLine(new string('=', 60));
        }
    }
}
