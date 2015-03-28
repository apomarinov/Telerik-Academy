using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    interface IDepositable
    {
        void Deposit(double amount);
    }
}
