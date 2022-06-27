using System;
using System.Globalization;
using System.Collections.Generic;
using inheritance1_csharp.Entities;

namespace inheritance1_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 136. Upcasting e downcasting
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //// UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            //if (acc3 is BusinessAccount)
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}
            #endregion

            #region 137. Sobreposição, palavras virtual, override e base
            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);
            #endregion

            #region 143. Classes abstratas
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            #endregion

        }
    }
}
