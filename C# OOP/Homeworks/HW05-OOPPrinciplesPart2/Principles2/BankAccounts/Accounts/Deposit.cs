using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principles2.BankAccounts.Customers;

namespace Principles2.BankAccounts.Accounts
{
    class Deposit : Account
    {
        public Deposit(Customer accCustomer, decimal balance, decimal intRate) : base(accCustomer, balance, intRate, Contracts.AccountType.deposit) { }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance <1000m) {return 0;}
            return months * InterestRate;
        }
    }
}
