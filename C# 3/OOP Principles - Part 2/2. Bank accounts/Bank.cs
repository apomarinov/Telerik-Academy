﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }
    }
}
