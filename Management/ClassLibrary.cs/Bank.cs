using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Bank
    {
        public Bank(string name)
        {
            this.Name = name;
        }
        
        private string Name { get; set; }
        public List<Account> list = new List<Account>();

        public void AddAccount(Account acc)
        {
            list.Add(acc);
        }
    }
}
