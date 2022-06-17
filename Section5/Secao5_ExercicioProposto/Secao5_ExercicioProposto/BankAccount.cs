using System;
using System.Globalization;

namespace Secao5_ExercicioProposto
{
    class BankAccount
    {
        public int Number { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public BankAccount(int number, string name, double initialDeposit) : this(number, name)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdrawal(double amount)
        {
            Balance -= amount + 5.00;
        }

        public override string ToString()
        {
            return String.Format($"Account {Number}, Holder: {Name}, Balance: $ {Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
