using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            // Ввод данных о запчастях с клавиатуры
            Console.WriteLine("Введите количество деталей:");
            int numberOfParts;
            while (!int.TryParse(Console.ReadLine(), out numberOfParts) || numberOfParts <= 0)
            {
                Console.WriteLine("Некорректное количество деталей. Пожалуйста, введите положительное целое число:");
            }

            for (int i = 0; i < numberOfParts; i++)
            {
                Console.WriteLine($"Введите данные для детали #{i + 1}:");
                Console.Write("Номер детали: ");
                string partNumber = Console.ReadLine();
                Console.Write("Название детали: ");
                string name = Console.ReadLine();
                Console.Write("Цена: ");
                decimal price;
                while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
                {
                    Console.WriteLine("Некорректная цена. Пожалуйста, введите положительное число:");
                }
                Console.Write("Количество: ");
                int quantity;
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Некорректное количество. Пожалуйста, введите положительное целое число:");
                }
                Console.Write("Лошадиные силы (для деталей двигателя, введите 0 если не применимо): ");
                int horsepower;
                while (!int.TryParse(Console.ReadLine(), out horsepower))
                {
                    Console.WriteLine("Некорректное значение. Пожалуйста, введите целое число:");
                }

                if (horsepower > 0)
                {
                    EnginePart enginePart = new EnginePart(partNumber, name, price, quantity, horsepower);
                    catalogue.AddPart(enginePart);
                }
                else
                {
                    Console.Write("Цвет (для кузовных деталей): ");
                    string color = Console.ReadLine();
                    BodyPart bodyPart = new BodyPart(partNumber, name, price, quantity, color);
                    catalogue.AddPart(bodyPart);
                }
            }

            // Отображение каталога запчастей
            Console.WriteLine("\nКаталог запчастей:");
            catalogue.ShowCatalog();

            // Вычисление общей стоимости запчастей в каталоге
            decimal totalValue = catalogue.CalculateTotalValue();
            Console.WriteLine($"\nОбщая стоимость запчастей в каталоге: {totalValue} руб.");

            // Пример поиска и удаления детали
            Console.Write("\nВведите номер детали для поиска: ");
            string searchPartNumber = Console.ReadLine();
            var foundPart = catalogue.FindPart(searchPartNumber);

            if (foundPart != null)
            {
                foundPart.DisplayInfo();
                Console.Write("\nХотите удалить эту деталь? (да/нет): ");
                if (Console.ReadLine().ToLower() == "да")
                {
                    catalogue.RemovePart(searchPartNumber);
                }
            }
            else
            {
                Console.WriteLine("Деталь не найдена.");
            }

            // Отображение обновленного каталога после удаления (если применимо)
            Console.WriteLine("\nОбновленный каталог запчастей:");
            catalogue.ShowCatalog();
        }

    }
}

