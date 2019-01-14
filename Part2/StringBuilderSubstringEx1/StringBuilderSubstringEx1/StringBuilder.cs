using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstringEx1
{
    public static class StringBuilder // The Extension Methods must be declared in a static class
    {
        public static string Substring(this string str, int index, int length) // Defined as static
        {
            return str.Substring(index, length);
        }
        
        // Am mentionat si "this string str", deoarece clasa este statica si trebuia sa fac referinta la string-ul pe care il modific.
        // In cerinta spunea sa returnam un new StringBuilder(). Nu cred ca am inteles bine cerinta..
    }
}
