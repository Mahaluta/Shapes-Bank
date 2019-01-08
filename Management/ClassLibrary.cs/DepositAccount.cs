using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class DepositAccount : Account
    {
        // constructors
        public DepositAccount(Customer customer,decimal balance,decimal interest_rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest_Rate = interest_rate;
        }

        // methods
        public void DrawMoney(int amount)
        {
            this.Balance -= amount;
        }

        public override decimal Calculate_Interest_Rate(int Months)
        {
            if(Balance>0 && Balance>1000)
            {
                return Months * Interest_Rate;
            }
            else
                throw new Exception("The interest rate couldn`t be calculated.");
        }
    }
}
