using Principles2.BankAccounts.Accounts;
using Principles2.BankAccounts.Contracts;
using Principles2.BankAccounts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles2.BankAccounts.TheBank
{
    class Bank
    {
        private List<Account> bankList;

        public Bank() { this.bankList = new List<Account>(); }
        public List<Account> BankList { get { return this.bankList; } }

        public void AddLoanAccount(Customer customer, decimal balance, decimal interestRate)
        {
            bankList.Add(new Loan(customer, balance, interestRate));
        }
        public void AddMortageAccount(Customer customer, decimal balance, decimal interestRate)
        {
            bankList.Add(new Mortage(customer, balance, interestRate));
        }
        public void AddDepositAccount(Customer customer, decimal balance, decimal interestRate)
        {
            bankList.Add(new Deposit(customer, balance, interestRate));
        }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Bank database");
            result.AppendLine("-----------------------\n");

            int counter = 1;
            foreach (var item in bankList)
            {
                result.AppendLine(String.Format("Account No:{0}", counter));
                result.AppendLine(item.CustomerToString());
                result.AppendLine(String.Format("Account Type: {0}", item.Type));
                result.AppendLine(String.Format("Balance: {0}", item.Balance));
                result.AppendLine(String.Format("Interest rate: {0}\n", item.InterestRate));
                counter++;

            }
            return result.ToString();
        }
    }
}
