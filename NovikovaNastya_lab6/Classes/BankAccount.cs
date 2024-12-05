using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NovikovaNastya_lab6
{
    class BankAccount
    {
        /// <summary>
        /// Номер счета
        /// </summary>
        private ulong AccountNumber;
        /// <summary>
        /// Баланс
        /// </summary>
        private decimal Balance;
        /// <summary>
        /// Тип счета
        /// </summary>
        private AccountType accountType;

        public BankAccount(ulong AccountNumber, decimal balance, AccountType accountType)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = balance;
            this.accountType = accountType;
        }
        //Метод, который возвращает номер счета
        public ulong GetAccountNumber()
        {
            return AccountNumber;
        }

        //Метод, который возвращает баланс
        public decimal GetBalance()
        {
            return Balance;
        }

        //Метод ,который возвращает тип счета 
        public AccountType GetAccountType()
        {
            return accountType;
        }

        //Метод для пополнения счета
        public void Refill(decimal amount)
        {
            if (amount>0)
            {
                Balance += amount;
                Console.WriteLine($"Баланс был пополнен на {amount}. Текущий баланс:{Balance}");
            }
            else
            {
                Console.WriteLine("Сумма пополнения должна быть положительной");
            }
        }

        //Метод для снятия средств со счета
        public void WithDraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Со счета снято {amount}.Остаток средств на счете:{Balance}");
            }
            else
            {
                Console.WriteLine("Недостаточно средств или неверная сумма для снятия");
            }
        }

        //Метод отображения информации о счете
        public void DisplayInfo()
        {
            Console.WriteLine($"Номер счета:{AccountNumber}");
            Console.WriteLine($"Баланс:{Balance}");
            Console.WriteLine($"Тип банковского счета:{accountType}");
        }
    }
}
