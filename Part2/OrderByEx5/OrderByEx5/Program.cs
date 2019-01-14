using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.FirstName = "Cristiano"; s1.LastName = "Ronaldo";
            s2.FirstName = "Paulo"; s2.LastName = "Dybala";
            s3.FirstName = "Gianluigi"; s3.LastName = "Buffon";
            s4.FirstName = "Hugo"; s4.LastName = "Lloris";

            list.Add(s1); list.Add(s2); list.Add(s3); list.Add(s4);

            var ordered = list
                .OrderByDescending(stud => stud.LastName)
                .Select(stud => stud);

            foreach(Student stud in ordered)
            {
                Console.WriteLine(stud.FirstName);
            }
            Console.ReadKey();                
        }
    }
}
