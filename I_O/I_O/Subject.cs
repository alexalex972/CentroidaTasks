using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_O
{
    public class Subject
    {
        public int subject;
        public List<Subject> requierments = new List<Subject>();

        public void printReq()
        {

            
            foreach(Subject a in requierments)
            {
                Console.WriteLine(a.subject);
                /*Console.WriteLine("Requiered Subjects: ");
                Console.WriteLine(a.subject);
                if (a.requierments.Count > 0)
                {
                    Console.WriteLine("------Subrequiered Subjects: ");
                    foreach (Subject b in a.requierments)
                    {
                        Console.WriteLine(b.subject);
                        b.printReq();
                    }
                }*/




            }
        }

        public void addReq(string b, List<Subject> s)
        {
           
            
                foreach(Subject el in s)
                {
                    if(Convert.ToInt32(b) == el.subject)
                    {
                        requierments.Add(el);
                    }
                
            }
            
        }



    }
}
