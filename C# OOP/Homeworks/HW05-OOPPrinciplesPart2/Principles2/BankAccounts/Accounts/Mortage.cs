using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Principles2.BankAccounts.Customers;
using Principles2.BankAccount.Contracts;

namespace Principles2.BankAccounts.Accounts
{
    class Mortage : Account
    {
        public Mortage(Customer accCustomer, decimal balance, decimal intRate) : base(accCustomer, balance, intRate,Contracts.AccountType.mortage) { }

        public override decimal CalculateInterest(int months)
        {
            decimal monthsCounter = 0;

            for (int i = 1; i <= months; i++)
            {
                if (AccCustomer.Type == CustomerType.individual && i <= 6) { continue; }
                else if (AccCustomer.Type == CustomerType.company && i < 12)
                {
                    monthsCounter += 0.5m;
                    continue;
                }
                monthsCounter++;
            }

            return monthsCounter * this.InterestRate;
        }
    }
}

