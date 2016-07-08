using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.ProductsCategory
{
    public class Category : ICategory
    {
        private const int CategoryMinLen = 2;
        private const int CategoryMaxLen = 15;
        private string name;
        private ICollection<IProduct> productsList;

        public Category(string name)
        {
            this.Name = name;
            this.ProductsList = new List<IProduct>();
        }
        public Category(string name, ICollection<IProduct> list)
        {
            this.Name = name;
            this.ProductsList = list;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(
                    value, CategoryMaxLen, CategoryMinLen,
                    String.Format(GlobalErrorMessages.InvalidStringLength,
                    this.GetType().Name + " name", CategoryMinLen, CategoryMaxLen));
                this.name = value;
            }
        }
        public ICollection<IProduct> ProductsList { get; set; }
        public void AddCosmetics(IProduct cosmetics)
        {
            this.ProductsList.Add(cosmetics);
        }
        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!(this.ProductsList.Contains(cosmetics)))
            {
                throw new MissingMemberException(String.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            this.ProductsList.Remove(cosmetics);
        }

        public virtual string Print()
        {
            StringBuilder forReturn = new StringBuilder();
            forReturn.AppendLine(String.Format("{0} category - {1} products/product in total", this.name, this.ProductsList.Count));

            foreach (var item in ProductsList)
            {
                forReturn.AppendLine(item.Print());
            }

            return forReturn.ToString();
        }

    }
}
