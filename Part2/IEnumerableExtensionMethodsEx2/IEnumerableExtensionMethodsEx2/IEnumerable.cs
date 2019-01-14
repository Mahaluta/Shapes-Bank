using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensionMethodsEx2
{
    public interface IEnumerable<T>
    {
        int sum(int a, int b);
        int prod(int a, int b);
        int avg(int a, int b);
        int min(int a, int b);
        int max(int a, int b);
    }
}
