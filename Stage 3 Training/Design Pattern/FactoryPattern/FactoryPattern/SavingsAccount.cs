using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class SavingsAccount : Account
    {
        private string _accountNumber;
        private int _balance;

        public override string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public override int Balance { get => _balance; set => _balance = value; }

        public override string AccountType { get => "Savings Account"; }
    }
}
