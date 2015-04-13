namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.products.Contains(product);
        }

        public decimal TotalPrice()
        {
            ///this.products.Aggregate((p1, p2) => p1.Price + p2.Price)
            decimal total = 0;
            foreach (Product p in this.products)
            {
                total += p.Price;
            }
            return total;
        }
    }
}
