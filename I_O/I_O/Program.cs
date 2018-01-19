using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace I_O
{
    class Program
    {



        static void Main(string[] args)
        {

            List<Subject> collectionSubject = new List<Subject>();

            var logFile = File.ReadAllLines("requierments.txt");
            var logList = new List<string>(logFile);
            string[] subjects;

            foreach(string item in logList)
            {
               subjects = item.Split(' ');
               Subject sub = new Subject();
               sub.subject = subjects[0];
                foreach (string req in subjects.Skip(1))
                {
                    sub.requierments.Add(req);
                }

                collectionSubject.Add(sub); 

            }


            foreach(Subject a in collectionSubject)
            {
                Console.WriteLine(a.subject);
                Console.WriteLine("- - -");
                a.printReq();
                Console.WriteLine();
            }
            
            Console.ReadLine();

        }
    }
}
