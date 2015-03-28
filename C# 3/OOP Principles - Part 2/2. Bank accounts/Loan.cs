using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Loan : Account, IDepositable
    {
        public Loan (Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double InterestAmount(int months)
        {
            months = MonthsByCustomerType(months);
            return months * this.InterestRate;
        }

        private int MonthsByCustomerType(int months)
        {
            if (this.Customer.Type == CustomerType.Individual)
            {
                months -= 3;
            }
            else if (this.Customer.Type == CustomerType.Company)
            {
                months -= 2;
            }

            if (months < 0)
            {
                months = 0;
            }

            return months;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
