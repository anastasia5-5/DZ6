using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya_lab6
{
    /// <summary>
    /// Виды банковского счета
    /// </summary>
    enum AccountType
    {
        Saving,  //Сберегательный
        Deposit, //Депозитный
        Currency //Валютный
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Task1();
            Task4();

            Console.WriteLine("Нажмите какую-нибудь клавишу");
            Console.ReadKey();

        }
        // Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип из упр. 3.1).
        // Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

        static void Task1()
        {
            Console.WriteLine("Упражнение 7.1");

            BankAccount FirstAccount = new BankAccount(55555555, 10005.0m, AccountType.Saving);
            FirstAccount.DisplayInfo();
            
            BankAccount SecondAccount = new BankAccount(66666666,28564.90m, AccountType.Deposit);
            SecondAccount.DisplayInfo();

            BankAccount ThirdAccount = new BankAccount(88888888, 6734.87m, AccountType.Currency);
            ThirdAccount.DisplayInfo();

            FirstAccount.Refill(600.00m);
            Console.WriteLine("\nПосле пополнения:");
            FirstAccount.DisplayInfo();

            FirstAccount.WithDraw(250.00m);
            Console.WriteLine("\nПосле снятия средств:");
            FirstAccount.DisplayInfo();

            SecondAccount.Refill(400.00m);
            Console.WriteLine("\nПосле пополнения:");
            SecondAccount.DisplayInfo();

            SecondAccount.WithDraw(100.50m);
            Console.WriteLine("\nПосле снятия средств:");
            SecondAccount.DisplayInfo();

            ThirdAccount.Refill(750.00m);
            Console.WriteLine("\nПосле пополнения:");
            ThirdAccount.DisplayInfo();

            ThirdAccount.WithDraw(700.00m);
            Console.WriteLine("\nПосле снятия средств:");
            ThirdAccount.DisplayInfo();
        }

        //Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
        //Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.
        static void Task4()
        {
            Console.WriteLine("Домашнее задание 7.1");

            // Создание объектов класса Building
            Building building1 = new Building(30.0, 10, 40, 2);
            Building building2 = new Building(45.0, 15, 75, 3);

            // Вывод информации о зданиях
            building1.DisplayInfo();
            Console.WriteLine();
            building2.DisplayInfo();
        }

    }
}
