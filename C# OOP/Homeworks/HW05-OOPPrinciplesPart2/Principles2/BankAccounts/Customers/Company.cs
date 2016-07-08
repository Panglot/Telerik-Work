
using Principles2.BankAccount.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles2.BankAccounts.Customers
{
    class Company:Customer
    {
        public string Name { get; set; }

        public Company(string name):base(CustomerType.company)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("Customer type: {0}\nName: {1}", this.Type, this.Name);
        }
    }
}
