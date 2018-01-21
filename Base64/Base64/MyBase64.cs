using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Base64
{
    public class MyBase64 
    {
        private string encodedString = ""; 

        public MyBase64(char[] initial)
        {
            byte[] endocedByte = ASCIIEncoding.ASCII.GetBytes(initial);
            encodedString = System.Convert.ToBase64String(endocedByte);

        }

        public string decode()
        {
            byte[] enBytes = Convert.FromBase64String(encodedString);
            encodedString = ASCIIEncoding.ASCII.GetString(enBytes);


            return encodedString;

        }

        public void print()
        {
            Console.WriteLine(encodedString);
        }

        public char this[int i]
        {
            get { return encodedString[i]; }
            set {
                StringBuilder sb = new StringBuilder(encodedString);
                sb[i] = value;
                encodedString = sb.ToString();
            }
        }

        public static MyBase64 operator +(MyBase64 left, MyBase64 right)
        {
            left.encodedString = left.encodedString + right.encodedString;
            return left; 
        }

    }
}
