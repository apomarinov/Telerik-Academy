namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;

    public class Category : ICategory
    {
        private string name;
        private List<IProduct> products;

        private const int nameMinLength = 2;
        private const int nameMaxLength = 15;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, nameMaxLength, nameMinLength,
                                                     String.Format(GlobalErrorMessages.InvalidStringLength, "Category name", nameMinLength, nameMaxLength));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.products.Contains(cosmetics))
            {
                throw new ArgumentException(String.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            var categoryString = new StringBuilder();
            string hasManyProducts = this.products.Count == 1 ? "product" : "products";
            categoryString.Append(String.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, hasManyProducts));

            this.SortProducts();

            foreach (Product p in this.products)
            {
                categoryString.Append(p.ToString());
            }

            return this.products.Count == 0 ? categoryString.ToString().Trim() : categoryString.ToString();
        }

        private void SortProducts()
        {
            this.products = this.products
                                .OrderBy(p => p.Brand)
                                .ThenByDescending(p => p.Price).ToList<IProduct>();
        }
    }
}
