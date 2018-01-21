using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64
{
    class MyBase64
    {
        public string encodedString;

        public MyBase64(char[] initial)
        {
            byte[] endocedByte = ASCIIEncoding.ASCII.GetBytes(initial);
            encodedString = System.Convert.ToBase64String(endocedByte);

        }

    }
}
