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

            Console.WriteLine("SubRequiered of that subject: ");
            foreach (Subject a in requierments)
            {
           
                Console.WriteLine("---" + a.subject);
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
