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
            a.print();

            char[] c = new char[] { };
            c = Console.ReadLine().ToCharArray();
            MyBase64 d = new MyBase64(c);
            d.print();


            a= a + d;
            a.print();

            //a += d;

           // a.print();


            Console.ReadLine();
            
       } 
    }
}
