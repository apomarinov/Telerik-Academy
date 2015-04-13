namespace Cosmetics.Products
{
    using System;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IProduct, IShampoo
    {
        private uint quantity;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint quantity, UsageType usage)
            :base(name, brand, gender, price)
        {
            this.Milliliters = quantity;
            this.Usage = usage;
        }

        public uint Milliliters
        {
            get { return this.quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Shampoo quantity must be positive!");
                }
                this.quantity = value;
            }
        }

        public UsageType Usage
        {
            get { return this.usage; }
            set
            {
                if (!UsageType.IsDefined(typeof(UsageType), value))
                {
                    throw new ArgumentException("Invalid Shampoo Usage Type!");
                }
                this.usage = value;
            }
        }

        public override decimal Price
        {
            get { return base.Price * this.Milliliters; }
            set
            {
                base.Price = value;
            }
        }

        public override string ToString()
        {
            string productString = base.Print();
            string shampooString = String.Format("  * Quantity: {0} ml{1}  * Usage: {2}",
                                                this.Milliliters, Environment.NewLine, this.Usage.ToString());

            return String.Format("{0}{1}{2}", productString, Environment.NewLine, shampooString);
        }
    }
}
