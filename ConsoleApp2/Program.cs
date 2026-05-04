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
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
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

       
    }
}