using System;

namespace StudentClasses
{
    public class Student : ICloneable, IComparable<Student>
    {
        // constructor
        public Student(string FN, string MN, string LN, int NUM)
        {
            this.FirstName = FN;
            this.MiddleName = MN;
            this.LastName = LN;
            this.SSN = NUM;
        }

        // fields
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int SSN { get; private set; }
        public string Adress { get; private set; }
        public string Mobile { get; private set; }
        public string Email { get; private set; }
        public string Course { get; private set; }
        public enum Specialty { IT, Business, Medicine };
        public enum University { Cuza, Asachi, Popa };
        public enum Faculty { INFO, FEAA, ETTI, AS, G };

        // methods
        public override bool Equals(object stud)
        {
            Student student = stud as Student;
            if (student == null)
                return false;
            if (Object.Equals(this.LastName, student.LastName))
                if (Object.Equals(this.MiddleName, student.MiddleName))
                    if (Object.Equals(this.FirstName, student.FirstName))
                        if(Object.Equals(this.SSN, student.SSN))
                            return true;
            return false;
        }

        public static bool operator == (Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator != (Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

        public object Clone()
        {
            Student stud = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN);
            // + celelalte field-uri
            return stud;
        }

        public int CompareTo(Student stud) 
        {
            if (String.Compare(this.FirstName, stud.FirstName) < 0)
            {
                Console.WriteLine("S1 FirstName < S2 FirstName");
                return -1; // passed object bigger than this instance
            }
            else if (String.Compare(this.FirstName, stud.FirstName) == 0)
            {
                if (this.SSN < stud.SSN)
                {
                    Console.WriteLine("S1 FisrtName = S2 FirstName, but S1 SSN < S2 SSN");
                    return -1; // passed object bigger than this instance
                }
                else if(this.SSN > stud.SSN)
                {
                    Console.WriteLine("S1 FisrtName = S2 FirstName, but S1 SSN > S2 SSN");
                    return 1; // passed object smaller than this instance
                }
            }
            if (String.Compare(this.FirstName, stud.FirstName) > 0)
            {
                Console.WriteLine("S1 FirstName > S2 FirstName");
                return 1; // passed object smaller than this instance
            }

            Console.WriteLine("S1 FirstName = S1 FirstName and S1 SSN = S2 SSN";
            return 0; // Equal objects

        }

        // destructor 
        ~Student()
        {
            Console.WriteLine($"The object '{FirstName} {MiddleName} {LastName}' was destroyed");
        }


    }
}
