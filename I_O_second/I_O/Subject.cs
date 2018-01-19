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

        public List<int> printReq(List<int> requie)
        {

           
            foreach (Subject a in requierments)
            {
           
                requie.Add(a.subject);
            }

            return requie;

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
