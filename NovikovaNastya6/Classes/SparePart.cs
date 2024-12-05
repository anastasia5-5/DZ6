using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya6
{
    //Абстрактный класс для запчастей
    public abstract class SparePart
    {
        /// <summary>
        /// Номер детали
        /// </summary>
        public string PartNumber { get; set; } 
        /// <summary>
        /// Название детали
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Цена детали
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Количество деталей 
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Абстрактный метод высвечивания информации
        /// </summary>
        public abstract void DisplayInfo();

        //Конструктор
        protected SparePart(string partNumber, string name, decimal price, int amount)
        {
            PartNumber = partNumber;
            Name = name;
            Price = price;
            Amount = amount;
        }

        /// <summary>
        /// Метод для обновления количества деталей
        /// </summary>
        /// <param name="newAmount"></param>
        public void UpdateAmount( int newAmount)
        {
            Amount = newAmount;
        }
        /// <summary>
        /// Метод получения итоговой стоимости всех деталей 
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalPrice()
        { 
            return Price * Amount;
        }
        /// <summary>
        /// Метод для проверки наличия деталей
        /// </summary>
        /// <returns></returns>
        public bool Availability()
        {
            return Amount > 0;
        }
        /// <summary>
        /// Метод для изменения цены
        /// </summary>
        /// <param name="newPrice"></param>
        public void ChangePrice(decimal newPrice)
        {
            Price = newPrice;
        }
    }
}
