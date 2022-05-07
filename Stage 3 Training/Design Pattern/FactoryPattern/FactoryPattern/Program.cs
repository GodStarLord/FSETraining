using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new SavingsAccount();
            account1.Balance = 1000;
            account1.AccountNumber = "1022254";

            Account account2 = new CurrentAccount();
            account2.Balance = 50000;
            account2.AccountNumber = "15554563";

            AccountFactory accountFactory = new AccountFactory();

            accountFactory.accounts.Add(account1);
            accountFactory.accounts.Add(account2);

            foreach (var account in accountFactory.accounts)
            {
                Console.WriteLine($"Account No - {account.AccountNumber} & Account Type - {account.AccountType}\n");
            }

            Console.Read();
        }
    }
}
