using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public abstract class Account
    {
        public Customer customer;
        protected double balance;
        protected double interestRate;

        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set {
                if (value == null)
                {
                    throw new ArgumentNullException("Missing customer");
                }
                this.customer = value; 
            }
        }

        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Balance");
                }
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Interest rate");
                }
                this.interestRate = value;
            }
        }

        public virtual double InterestAmount(int months) {
            return (double)months * this.InterestRate;
        }
    }
}
