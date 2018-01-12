using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            OpenQuestion question = new OpenQuestion("asd", 10);
            question.ask();
            Console.WriteLine(question.answer);
            Console.ReadLine();

        }

        
    }
}
