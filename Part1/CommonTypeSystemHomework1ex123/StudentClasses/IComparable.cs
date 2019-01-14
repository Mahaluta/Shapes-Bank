using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClasses
{
    interface IComparable<Student>
    {
        int CompareTo(Student stud); 
    }
}
