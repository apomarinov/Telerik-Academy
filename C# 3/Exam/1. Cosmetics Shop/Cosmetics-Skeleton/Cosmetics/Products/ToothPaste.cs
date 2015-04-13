namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class ToothPaste : Product, IProduct, IToothpaste
    {
        private List<string> ingredients;

        private const int ingridientMinLength = 4;
        private const int ingridientMaxLength = 12;

        public ToothPaste(string name, string brand, decimal price, GenderType gender, IList<string> ingridients)
            : base(name, brand, gender, price)
        {            
            AssignIngredients(ingridients);
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        private void AssignIngredients(IEnumerable<string> ingridients)
        {
            this.ingredients = new List<string>();
            foreach (string ing in ingridients)
            {
                ValidateIngridient(ing);
                this.ingredients.Add(ing);
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                base.Price = value;
            }
        }

        private void ValidateIngridient(string ingridient)
        {
            Validator.CheckIfStringIsNullOrEmpty(ingridient, GlobalErrorMessages.StringCannotBeNullOrEmpty);
            Validator.CheckIfStringLengthIsValid(ingridient, ingridientMaxLength, ingridientMinLength,
                                                 String.Format(GlobalErrorMessages.InvalidStringLength, "Each ingridient", ingridientMinLength, ingridientMaxLength));
        }

        public override string ToString()
        {
            string productString = base.Print();
            string toothPasteString = String.Format("  * Ingredients: {0}", this.Ingredients);

            return String.Format("{0}{1}{2}", productString, Environment.NewLine, toothPasteString);
        }
    }
}
