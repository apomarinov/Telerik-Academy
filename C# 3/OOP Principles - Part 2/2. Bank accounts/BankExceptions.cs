using System;

namespace BankingSystem
{
    public class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string message)
            : base(message)
        {
        }

        public InsufficientFundsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}