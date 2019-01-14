using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRangeEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            s1.FirstName = "Cristiano"; s1.LastName = "Ronaldo"; s1.Age = 19;
            s2.FirstName = "Paulo"; s2.LastName = "Dybala"; s2.Age = 26;
            s3.FirstName = "Gianluigi"; s3.LastName = "Buffon"; s3.Age = 23;

            list.Add(s1); list.Add(s2); list.Add(s3);

            var ordered =
                from stud in list
                where stud.Age > 18
                where stud.Age < 24
                orderby stud.FirstName
                select stud;

            foreach(Student std in ordered)
            {
                Console.WriteLine(std.FirstName);
            }

            Console.ReadKey();

        }
    }
}
