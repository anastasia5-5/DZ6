using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya_lab6
{
    public class Building
    {
        
        private static int lastBuildingNumber = 0; // Статическое поле для хранения последнего использованного номера здания
        private int buildingNumber; // Уникальный номер здания
        private double height; // Высота здания в метрах
        private int floors; // Этажи
        private int apartments; // Количество квартир
        private int entrances; // Количество подъездов

        /// <summary>
        /// Конструктор, который автоматически присваивает уникальный номер зданию
        /// </summary>
        /// <param name="height"></param>
        /// <param name="floors"></param>
        /// <param name="apartments"></param>
        /// <param name="entrances"></param>
        public Building(double height, int floors, int apartments, int entrances)
        {
            this.buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }

        /// <summary>
        /// Метод для генерации уникального номера здания
        /// </summary>
        /// <returns></returns>
        private int GenerateBuildingNumber()
        {
            lastBuildingNumber++;
            return lastBuildingNumber;
        }

        /// <summary>
        /// Метод для получения номера здания
        /// </summary>
        /// <returns></returns>
        public int GetBuildingNumber()
        {
            return buildingNumber;
        }

        /// <summary>
        /// Метод для получения высоты здания
        /// </summary>
        /// <returns></returns>
        public double GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Метод для получения этажности
        /// </summary>
        /// <returns></returns>
        public int GetFloors()
        {
            return floors;
        }

        /// <summary>
        /// Метод для получения количества квартир
        /// </summary>
        /// <returns></returns>
        public int GetApartments()
        {
            return apartments;
        }

        /// <summary>
        /// Метод для получения количества подъездов
        /// </summary>
        /// <returns></returns>
        public int GetEntrances()
        {
            return entrances;
        }

        /// <summary>
        /// Метод для вычисления высоты этажа
        /// </summary>
        /// <returns></returns>
        public double CalculateFloorHeight()
        {
            if (floors > 0)
                return height / floors;
            else
                return 0; 
        }

        /// <summary>
        /// Метод для вычисления количества квартир в одном подъезде
        /// </summary>
        /// <returns></returns>
        public int CalculateApartmentsPerEntrance()
        {
            if (entrances > 0)
                return apartments / entrances;
            else
                return 0; 
        }

        /// <summary>
        /// Метод для вычисления количества квартир на этаже
        /// </summary>
        /// <returns></returns>
        public int CalculateApartmentsPerFloor()
        {
            if (floors > 0)
                return apartments / floors;
            else
                return 0; 
        }

        /// <summary>
        /// Метод для отображения информации о здании
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Уникальный номер здания: {buildingNumber}");
            Console.WriteLine($"Высота здания: {height} м");
            Console.WriteLine($"Этажность: {floors}");
            Console.WriteLine($"Количество квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entrances}");
            Console.WriteLine($"Высота этажа: {CalculateFloorHeight()} м");
            Console.WriteLine($"Количество квартир в подъезде: {CalculateApartmentsPerEntrance()}");
            Console.WriteLine($"Количество квартир на этаже: {CalculateApartmentsPerFloor()}");
        }


    }
}
