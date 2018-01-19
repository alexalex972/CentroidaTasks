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
        

        public static void requieredSubjects(List<Subject> a, int subjectWanted)
        {

            Console.WriteLine("Desired Subject: " + a[subjectWanted].subject);
            if(a[subjectWanted].requierments.Count == 0)
            {
                Console.WriteLine("Requiered Subjects None");
            }
            else
            {
                Console.WriteLine("Requiered Subjects: ");
                a[subjectWanted].printReq();
            }
            



         }

        static void Main(string[] args)
        {

            List<Subject> collectionSubject = new List<Subject>();

            var logFile = File.ReadAllLines("requierments.txt");
            var logList = new List<string>(logFile);
            string[] subjects;
            

            for(int i=0; i <logList.Count;i++)
            {
               subjects = logList[i].Split(' ');
               Subject sub = new Subject();
               sub.subject = Convert.ToInt32(subjects[0]);

                

               collectionSubject.Add(sub); 


            }

            for (int i = 0; i < logList.Count; i++)
            {
                subjects = logList[i].Split(' ');

                if(collectionSubject[i].subject == Convert.ToInt32(subjects[0]))
                {
                    foreach(string item in subjects.Skip(1))
                    {
                        collectionSubject[i].addReq(item, collectionSubject);
                    }
                }
                

            }


            /*foreach (Subject a in collectionSubject)
            {
                Console.WriteLine(a.subject);
                Console.WriteLine("- - -");
                a.printReq();
                Console.WriteLine();
            }*/

            requieredSubjects(collectionSubject, 0);


            Console.ReadLine();

        }
    }
}
