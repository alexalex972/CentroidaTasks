using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] b = new char[] { };

            b = Console.ReadLine().ToCharArray();
            MyBase64 a = new MyBase64(b);

            Console.WriteLine(a.encodedString);
            Console.ReadLine();
            
        }
    }
}
