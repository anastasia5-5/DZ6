using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya6
{
    public  class Catalogue
    {
        /// <summary>
        /// Объявление поля в классе
        /// </summary>
        private List<SparePart> parts;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Catalogue()
        {
            parts = new List<SparePart>();
        }
        /// <summary>
        /// Метод для добавления детали в каталог
        /// </summary>
        /// <param name="part"></param>
        public void AddPart(SparePart part)
        {
            parts.Add(part);
            Console.WriteLine($"Добавлена деталь: {part.Name}");
        }

        /// <summary>
        /// Метод для отображения каталога запчастей
        /// </summary>
        public void ShowCatalog()
        {
            foreach (var part in parts)
            {
                part.DisplayInfo();
            }
        }

        /// <summary>
        /// Метод для вычисления общей стоимости запчастей в каталоге
        /// </summary>
        /// <returns></returns>
        public decimal CalculateTotalValue()
        {
            decimal totalValue = 0;
            foreach (var part in parts)
            {
                totalValue += part.GetTotalPrice();
            }
            return totalValue;
        }

        /// <summary>
        /// Метод для поиска детали по номеру
        /// </summary>
        /// <param name="partNumber"></param>
        /// <returns></returns>
        public SparePart FindPart(string partNumber)
        {
            return parts.Find(part => part.PartNumber == partNumber);
        }

        /// <summary>
        /// Метод для удаления детали из каталога
        /// </summary>
        /// <param name="partNumber"></param>
        public void RemovePart(string partNumber)
        {
            var part = FindPart(partNumber);
            if (part != null)
            {
                parts.Remove(part);
                Console.WriteLine($"Удалена деталь: {part.Name}");
            }
            else
            {
                Console.WriteLine("Деталь не найдена.");
            }
        }

    }
}
