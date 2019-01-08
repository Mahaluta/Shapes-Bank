using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class LoanAccount : Account
    {
        // constructor
        public LoanAccount(Customer customer, decimal balance, decimal interest_rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest_Rate = interest_rate;

        }

        // methods
        public override decimal Calculate_Interest_Rate(int Months)
        {
            if ((this.Customer is Individual) && (Months <= 3))
                return 0;
            else if ((this.Customer is Company) && (Months <= 2))
                return 0;
            else
                return Months * Interest_Rate;
        }
    }
}
