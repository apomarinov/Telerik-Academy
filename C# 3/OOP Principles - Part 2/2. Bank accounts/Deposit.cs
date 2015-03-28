using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit (Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double InterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return (double)0;
            }
            else
            {
                return base.InterestAmount(months);
            }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (this.Balance - amount < 0)
            {
                throw new InsufficientFundsException("Not enough funds available");
            }
            this.Balance -= amount;
        }
    }
}
