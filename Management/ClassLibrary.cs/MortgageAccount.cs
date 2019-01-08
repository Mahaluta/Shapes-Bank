using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary 
{
    public class MortgageAccount : Account
    {
        // constructor
        public MortgageAccount(Customer customer, decimal balance, decimal interest_rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest_Rate = interest_rate;
        }

        // methods
            public override decimal Calculate_Interest_Rate(int Months)
        {
            if (this.Customer is Company && Months <= 12)
                return Interest_Rate * Months / 2;
            else if (this.Customer is Company && Months > 12)
                return Interest_Rate * Months;

            if (this.Customer is Individual && Months <= 6)
                return 0;
            else if (this.Customer is Individual && Months > 6)
                return Interest_Rate * Months;
            return Interest_Rate * Months;
        }
    }
}
