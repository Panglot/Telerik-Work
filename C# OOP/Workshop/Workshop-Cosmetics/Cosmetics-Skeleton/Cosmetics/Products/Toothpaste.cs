using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste, IProduct
    {

        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender,IList<string> ingredients):base (name,brand,price, gender)
        {
            this.Ingredients = String.Join(", ", ingredients);
        }


        public string Ingredients
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                this.ingredients = value;
            }
        }

        public override string Print()
        {
            StringBuilder forReturn = new StringBuilder();
            forReturn.Append(base.Print());
            forReturn.AppendLine(String.Format(" * Ingredients: {0}", this.Ingredients));

            return forReturn.ToString();
        }
    }
}
