using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Account
    {
        // fields
        protected Customer Customer { get; set; }
        protected decimal Balance { get; set; }
        protected decimal Interest_Rate { get; set; }
        protected int Months { get; set; }

        // methods
        public void DepositMoney(int amount)
        {
            this.Balance += amount;
        }

        public abstract decimal Calculate_Interest_Rate(int Months);

    }
}
