using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensionMethodsEx2
{
    public static class Enumerable       // Extension Methods must be declared in a static class
                                                        // A static class cannot inherit interfaces
    {
        public static int sum(int a, int b) { return a + b; }
        public static int prod(int a, int b) { return a * b; }
        public static int avg(int a, int b) { return (a + b) / 2; }
        public static int min(int a, int b) { if (a < b) return a; return b; }
        public static int max(int a, int b) { if (a > b) return a; return b; }
    }
}
