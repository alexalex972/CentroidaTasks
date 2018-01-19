using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_O
{
    public class Subject
    {
        public string subject = "";
        public List<string> requierments = new List<string>();

        public void printReq()
        {
            foreach(string a in requierments)
            {
                Console.WriteLine(a);
            }
        }
        
    }
}
