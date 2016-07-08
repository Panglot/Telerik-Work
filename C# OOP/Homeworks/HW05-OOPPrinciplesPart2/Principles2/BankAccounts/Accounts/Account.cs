using Principles2.BankAccounts.Contracts;
using Principles2.BankAccounts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles2.BankAccounts.Accounts
{
    class Account
    {

        public readonly AccountType type;
        public AccountType Type { get; }
        public Customer AccCustomer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public Account(Customer accCustomer, decimal balance, decimal intRate, AccountType type)
        {
            this.AccCustomer = accCustomer;
            this.Balance = balance;
            this.InterestRate = intRate;
            this.type = type;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return months * this.InterestRate;
        }

        public string CustomerToString()
        {
            return this.AccCustomer.ToString();
        }
    }
}
