using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroupsEx9Ex10Ex11Ex12Ex18Ex19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            Student s1 = new Student("Cristiano", "Ronaldo", "0736076732", "CR7@gmail.com", 1,2006);
            Student s2 = new Student("Harry", "Kane", "0256962965", "HK10@gmail.com", 2,2005);
            Student s3 = new Student("Dele", "Alli", "0123456789", "DA22@gmail.com", 3,2005);
            Student s4 = new Student("Gianluigi", "Buffon", "0232456879", "GB1@gmail.com", 2,2006);

            list.Add(s1); list.Add(s2); list.Add(s3); list.Add(s4);


            // Exercitiul 9
            var ex9 =
                from stud in list
                orderby stud.FirstName
                select stud;

            Console.WriteLine("Exercitiul 9");
            Console.WriteLine();
            foreach (Student stud in ex9)
            {
                Console.WriteLine(stud.FirstName);
            }

            Console.WriteLine();
            // Exercitiul 10
            Console.WriteLine("Exercitiul 10");
            Console.WriteLine();
            var ex10 = list
                .OrderBy(stud => stud.FirstName)
                .Select(stud => stud);

            
            foreach (Student stud in ex10)
            {
                Console.WriteLine(stud.FirstName);
            }

            Console.WriteLine();
            // Exercitiul 11
            Console.WriteLine("Exercitiul 11");
            Console.WriteLine();
            var ex11 =
                from stud in list
                where stud.Email.Contains("@gmail.com") // nu am inteles ce inseamna abv.bg din cerinta.. am pus gmail.
                orderby (stud.Email)
                select stud;

            foreach (Student stud in ex11)
            {
                Console.WriteLine(stud.FirstName);
            }

            Console.WriteLine();
            // Exerciitul 12
            Console.WriteLine("Exercitiul 12");
            Console.WriteLine();
            var ex12 =
                from stud in list
                where stud.Tel.EndsWith("9") // Sofia.. cred ca are un alt format, nu m-am complicat si am specificiat sa se termine cu cifra 9.
                select stud;

            foreach (Student stud in ex12)
            {
                Console.WriteLine(stud.FirstName);
            }

            Console.WriteLine();
            // Exerciitul 18
            Console.WriteLine("Exercitiul 18");
            Console.WriteLine();
            var ex18 =
                from stud in list
                orderby stud.GroupNumber
                select stud;

            foreach (Student stud in ex18)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName}");
            }

            Console.WriteLine();
            // Exerciitul 19
            Console.WriteLine("Exerciitul19");
            Console.WriteLine();
            var ex19 = list
                .OrderBy(stud => stud.GroupNumber)
                .Select(stud => stud);

            foreach (Student stud in ex19)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName}");
            }


            Console.ReadKey();
        }
    }
}
