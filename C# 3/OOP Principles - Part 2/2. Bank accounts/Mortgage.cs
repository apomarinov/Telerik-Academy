using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Mortgage : Account, IDepositable
    {
        public Mortgage (Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double InterestAmount(int months)
        {
            if (this.Customer.Type == CustomerType.Individual)
            {
                months -= 6;
                if (months < 0)
                {
                    months = 0;
                }
                return months * this.InterestRate;
            }
            else if (this.Customer.Type == CustomerType.Company)
            {
                return months * this.InterestRate * (months <= 12 ? 0.5 : 1);
            }            
            return months * this.InterestRate;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
