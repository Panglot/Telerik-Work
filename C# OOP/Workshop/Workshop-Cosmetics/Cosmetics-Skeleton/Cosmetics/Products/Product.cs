using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Product : IProduct
    {

        private decimal price;
        private string name;
        private string brand;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;

        }


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            protected set
            {

                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {

                this.price = value;
            }
        }

        public GenderType Gender { get; set; }
        public virtual string Print()
        {
            StringBuilder forReturn = new StringBuilder();
            forReturn.AppendLine(String.Format("- {0} - {1}:", this.Brand, this.Name));
            forReturn.AppendLine(String.Format(" * Price: ${0}", this.Price));
            forReturn.AppendLine(String.Format(" * For gender: {0}", this.Gender));
            return forReturn.ToString();
        }
    }
}
