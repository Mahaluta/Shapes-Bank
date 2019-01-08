using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace Management
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank B = new Bank("ING");
            Customer C1 = new Individual("Alex");
            Customer C2 = new Company("HUGO BOSS");
            Customer C3 = new Company("Hollister");

            
            Account A1 = new DepositAccount(C1, 1020, 1620);
            Account A2 = new LoanAccount(C2, 190, 1210);
            Account A3 = new MortgageAccount(C3, 400, 980);

            B.AddAccount(A1);
            B.AddAccount(A2);
            B.AddAccount(A3);

            foreach (Account acc in B.list)
            {
                Console.WriteLine(acc.Calculate_Interest_Rate(14));
            }

            Console.ReadKey();

            
        }
    }
}
