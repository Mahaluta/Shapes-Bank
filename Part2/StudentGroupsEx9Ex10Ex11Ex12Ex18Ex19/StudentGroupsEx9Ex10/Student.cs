using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroupsEx9Ex10Ex11Ex12Ex18Ex19
{
    public class Student
    {
        // constructor
        public Student(string firstname,string lastname,string tel, string email, int groupnumber, int fn)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupnumber;
            this.FN = fn;
        }

        // fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double> Marks = new List<double>();
        public int GroupNumber { get; set; }
    }
}
