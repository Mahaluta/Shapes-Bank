using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystemHomework2
{
    public class Person
    {
        public Person(string n)
        {
            this.Name = n;
        }

        private string Name { get; set; }
        private int? Age = null;

        public void SetAge(int a)
        {
            this.Age = a;
        }

        public override string ToString()
        {
            if(this.Age != null)
            return $"{this.Name} - {this.Age}";
            return $"{this.Name} - 'Age is not specified'";
        }
    }
}
