using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya6
{
    public class BodyPart : SparePart
    {
        /// <summary>
        /// Свойство ; Цвет
        /// </summary>
        public string Colour { get; set; }

        //Конструктор
        public BodyPart() : base("COL000", "Неизвестная деталь", 0m, 0) { }

        //Конструктор с параметрами
        public BodyPart(string PartNumber, string Name, decimal price, int amount, string colour) : base(PartNumber, Name, price, amount)
        {
            Colour = colour;
        }
        /// <summary>
        /// Переопределение метода
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Кузовная деталь: {Name}, Номер детали: {PartNumber}, Цена: {Price}, Количество: {Amount}, Цвет: {Colour}");
        }
        /// <summary>
        /// Метод для получения цвета детали
        /// </summary>
        /// <returns></returns>
        public string GetColourInfo()
        {
            return $"{Name} имеет цвет {Colour}.";
        }

        /// <summary>
        /// Метод для проверки цвета детали
        /// </summary>
        /// <param name="colorToCheck"></param>
        /// <returns></returns>
        public bool IsColor(string colourToCheck)
        {
            return Colour.Equals(colourToCheck, StringComparison.OrdinalIgnoreCase);
        }
    }
}
