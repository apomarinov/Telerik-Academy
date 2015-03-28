using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public enum CustomerType
    {
        Individual,
        Company
    }

    public class Customer
    {
        private CustomerType type;

        public Customer(CustomerType type)
        {
            this.Type = type;
        }

        public CustomerType Type
        {
            get { return this.type; }
            set
            {
                if (!CustomerType.IsDefined(typeof(CustomerType), value))
                {
                    throw new ArgumentException("Invalid customer type");
                }
                this.type = value;
            }
        }
    }
}
