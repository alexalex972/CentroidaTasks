using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Variable<int>();
            a.value = 6;
            a.name = "myname";

            var b = new Variable<int>();
            b.value = 5;
            b.name = "myname";

            Variable<int>.showValue(a);
            Variable<int>.showValue(b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            Variable<int>.swapValue(a, b);
            Variable<int>.showValue(a);
            Variable<int>.showValue(b);
            Console.ReadLine();

            b.getValue();
            b.setValue(10);
            b.getValue();

            Console.ReadLine();
        }
    }
}
