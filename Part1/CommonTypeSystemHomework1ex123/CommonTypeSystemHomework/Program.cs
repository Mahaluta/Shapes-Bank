using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClasses;

namespace CommonTypeSystemHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Cristiano", "dos Santos", "Ronaldo", 1213);
            Student s2 = new Student("Harry", "Daniel", "Kane", 1484);
            Student s3 = new Student("Harry", "Test", "Test", 1777); // tester
            Student s4 = new Student("Cristiano", "dos Santos", "Ronaldo", 1213555); // tester

            // Equals()
            Console.WriteLine("Testing Equals()");
            if(s1==s4)
            {
                Console.WriteLine("S1 e acelasi student cu S4"); // Chiar daca nu este adevarat, deoarece au alt SSN.
                // Pentru a verifica daca sunt diferiti, se foloseste GetHashCode().
            }
            else
            {
                Console.WriteLine("S1 si S4 sunt studenti diferiti."); // Ceea ce nu se intampla in cazul acesta.
            }

            // GetHashCode()
            Console.WriteLine("Testing GetHashCode()");
            if (s1.GetHashCode() != s4.GetHashCode())
                Console.WriteLine($"{s1.FirstName} {s1.LastName} {s1.SSN} si {s4.FirstName} {s4.LastName} {s4.SSN} sunt studenti diferiti.");
            else
            {
                Console.WriteLine($"Acelasi student");
            }

            // ToString()
            Console.WriteLine("Testing ToString()");
            Console.WriteLine(s1.ToString());


            // Clone()
            Console.WriteLine("Testing Clone()");
            Student s5 = s1.Clone() as Student;
            Console.WriteLine(s5.FirstName);

            // CompareTo(obj)
            Console.WriteLine("Testing CompareTo(obj)");
            if (s2.CompareTo(s3) < 0)
            {
                
                Console.WriteLine($"{s2.FirstName} {s2.LastName} {s2.SSN}");
                Console.WriteLine($"{s3.FirstName} {s3.LastName} {s3.SSN}");
            }
            else if(s1.CompareTo(s3)>0)
            {
                Console.WriteLine($"{s3.FirstName} {s3.LastName} {s3.SSN}");
                Console.WriteLine($"{s2.FirstName} {s2.LastName} {s2.SSN}");
            }
            else
            {
                Console.WriteLine("Same stats for both students.");
            }

            Console.ReadKey();


        }
    }
}
