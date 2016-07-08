using Principles2.BankAccount.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles2.BankAccounts.Customers
{
    class Individual: Customer
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public Individual(string firstName, string lastName):base(CustomerType.individual)
        {
            this.Firstname = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return String.Format("Customer type: {0}\nName: {1} {2}", this.Type, this.Firstname,this.LastName);
        }
    }
}
