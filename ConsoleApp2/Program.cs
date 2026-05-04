using System;
using System.Collections.Generic;

namespace GalaxiesDebugDemo
{
    public class Galaxy
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double DistanceLightYears { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Type}) - {DistanceLightYears} св. лет";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каталог галактик\n");

            // Создаём список с потенциальными проблемами
            List<Galaxy> galaxies = CreateGalaxyList();

            // МЕТОД С ОШИБКОЙ: раскомментируйте, чтобы увидеть ошибку
            // DisplayGalaxiesWithError(galaxies);

            // ИСПРАВЛЕННАЯ ВЕРСИЯ:
            DisplayGalaxiesFixed(galaxies);

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
        static List<Galaxy> CreateGalaxyList()
        {
            return new List<Galaxy>
            {
                new Galaxy { Name = "Млечный Путь", Type = "Спиральная", DistanceLightYears = 0 },
                new Galaxy { Name = "Андромеда", Type = "Спиральная", DistanceLightYears = 2537000 },
                null, // Потенциальная проблема - null элемент
                new Galaxy { Name = "Галактика Водоворот", Type = "Спиральная", DistanceLightYears = 23000000 },
                new Galaxy { Name = "Sombrero", Type = "Спиральная", DistanceLightYears = 29000000 },
                null  // Ещё один null элемент
            };
        }

    }
}