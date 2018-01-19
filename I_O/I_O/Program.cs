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
            Console.WriteLine();
            if (a[subjectWanted].requierments.Count == 0)
            {
                Console.WriteLine("Requiered Subjects None");
            }
            else
            {
                foreach(Subject item in a[subjectWanted].requierments)
                {
                    Console.WriteLine("Requiered Subject: "+item.subject);
                    item.printReq();
                    Console.WriteLine();
                }
                

            
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

            for (int j = 0; j < logList.Count; j++)
            {
                subjects = logList[j].Split(' ');
                


                if (collectionSubject[j].subject == Convert.ToInt32(subjects[0]))
                {
                    foreach(string item in subjects.Skip(1))
                    {
                        if (collectionSubject[j].subject == Convert.ToInt32(item))
                        {
                            Console.WriteLine("Error, Please fix it! ");
                            Console.ReadLine();
                            return;
                        }
                        else { collectionSubject[j].addReq(item, collectionSubject); }
                    }
                }
                

            }

            requieredSubjects(collectionSubject, 3);


            Console.ReadLine();

        }
    }
}
