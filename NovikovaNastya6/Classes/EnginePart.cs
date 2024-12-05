using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya6
{
    public class EnginePart : SparePart
    {
        /// <summary>
        /// Свойство ; Лошадиная сила
        /// </summary>
        public int HorsePower { get; set; }

        public EnginePart() : base("ENG000", "Неизвестная деталь", 0m, 0){ }

        //Конструктор с параметрами
        public EnginePart(string partNumber, string name, decimal price, int amount, int horsePower): base(partNumber, name, price, amount)
        {
            HorsePower = horsePower;
        }
        /// <summary>
        /// Переопределение метода
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Деталь двигателя: {Name}.Номер детали:{PartNumber}.Цена:{Price}.Количество:{Amount}.Лошадиные силы:{HorsePower}");
        }
        /// <summary>
        /// Метод для получения мощности в л.с.
        /// </summary>
        /// <returns></returns>
        public string GetHorsePowerInfo()
        { 
            return $"{Name} имеет мощность {HorsePower} л.с.";
        }

        /// <summary>
        /// Метод для проверки соответствия мощности
        /// </summary>
        /// <returns></returns>
        public bool IsMatchPower()
        { 
            return HorsePower > 200;
        }
    }
}
