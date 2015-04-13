namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Product : IProduct
    {
        private string name;
        private string brand;
        private GenderType gender;
        private decimal price;

        private const int nameMinLength = 3;
        private const int nameMaxLength = 10;
        private const int brandMinLength = 2;
        private const int brandMaxLength = 10;

        public Product(string name, string brand, GenderType gender, decimal price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Gender = gender;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, nameMaxLength, nameMinLength,
                                                     String.Format(GlobalErrorMessages.InvalidStringLength, "Product name", nameMinLength, nameMaxLength));
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, brandMaxLength, brandMinLength,
                                                     String.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", brandMinLength, brandMaxLength));
                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Product Price!");
                }
                this.price = value;
            }
        }

        public GenderType Gender
        {
            get { return this.gender; }
            set
            {
                if (!GenderType.IsDefined(typeof(GenderType), value))
                {
                    throw new ArgumentException("Invalid Product Gender Type!");
                }
                this.gender = value;
            }
        }

        public string Print()
        {
            var productString = new StringBuilder();

            productString.AppendLine(String.Format("{2}- {0} - {1}:", this.Brand, this.Name, Environment.NewLine));
            productString.AppendLine(String.Format("  * Price: ${0}", this.Price));
            productString.AppendLine(String.Format("  * For gender: {0}", this.Gender.ToString()));

            return productString.ToString().TrimEnd();
        }
    }
}
