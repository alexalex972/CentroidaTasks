using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_second
{
    class Program
    {
        static void Main(string[] args)
        {


            Test test1 = new Test();

            test1.addQuestion("Yes/No Question", "Are you good with OOP", 10, true);

            string answers = "a,b";
            string[] example = { "18", "30", "70", "20" };
            test1.addQuestion("Multiple Choice Question", "How old is Alex", 10, answers, example);

            test1.addQuestion("Open Question", "How tall is the Eiffel Tower", 10);

            test1.doTest();
            Console.WriteLine("Total Score:" +test1.gradeTest());
            

            Console.ReadLine();


        }
    }
}
