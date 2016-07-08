using Principles2.BankAccount.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles2.BankAccounts.Customers
{
    class Customer
    {
        public readonly CustomerType type;
        public CustomerType Type { get; }
        public Customer(CustomerType setType)
        {
            this.type = setType;
        }
    }
}
