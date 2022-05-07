using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class Account
    {
        public abstract string AccountType { get; }
        public abstract string AccountNumber { get; set; }
        public abstract int Balance { get; set; }
    }
}
