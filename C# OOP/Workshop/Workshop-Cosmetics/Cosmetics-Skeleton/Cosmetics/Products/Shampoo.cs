using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo, IProduct
    {

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage):base(name,brand,price,gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;

        }


        public uint Milliliters { get; set; }

        public UsageType Usage { get; set; }

        public override string Print()
        {
            StringBuilder forReturn = new StringBuilder();
            forReturn.Append(base.Print());
            if (this.Milliliters!=0)
            {
                forReturn.AppendLine(String.Format(" * Quantity: {0} ml", this.Milliliters));
            }
            forReturn.AppendLine(String.Format(" * Usage: {0}", Usage));

            return forReturn.ToString();
        }
    }
}
