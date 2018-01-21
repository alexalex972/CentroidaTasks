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
        //операция за индексиране [], която да връща пореден байт в оригиналния масив 
        public char this[int i]
        {
            get { return encodedString[i]; }
            set {
                StringBuilder sb = new StringBuilder(encodedString);
                sb[i] = value;
                encodedString = sb.ToString();
            }
        }
        //операции +, += за конкатениране на два base64-кодирани масива 
        public static MyBase64 operator +(MyBase64 left, MyBase64 right)
        {
            left.encodedString = left.encodedString + right.encodedString;
            return left; 
        }
        //операция () за на 'Vмиране на base64-кодиран подмасив от дадена позиция и с дадена дължина 
        public void find(MyBase64 encoded, int pos, int len)
        {
            encoded.encodedString.Substring(pos, len);
        }

        //операция () за вмъкване на base64-кодиран масив на произволна позиция в друг
        // като позицията се указва в брой байтове от началото на декодирания масив.
        public void insert(MyBase64 encoded2, int pos)
        {
            encodedString = this.decode();
            byte[] enBytes1 = Convert.FromBase64String(encodedString);
            byte[] enBytes2 = Convert.FromBase64String(encoded2.encodedString);

            List<byte> myBytes1 = new List<Byte>(enBytes1);
            List<byte> myBytes2 = new List<Byte>(enBytes2);

            myBytes1.InsertRange(pos, myBytes2);
            byte[] enBytes3 = myBytes1.ToArray();
            encodedString = System.Convert.ToBase64String(enBytes3);


            Console.WriteLine(encodedString);
        }

        //операция, която изтрива последователност от байтове от дадена позиция 
        public void delete(int bites, int pos)
        {
            byte[] myBytes = Convert.FromBase64String(encodedString);
            List<byte> myBytes1 = new List<Byte>(myBytes);

            myBytes1.RemoveRange(pos, bites);
            byte[] enBytes3 = myBytes1.ToArray();
            encodedString = System.Convert.ToBase64String(enBytes3);
            Console.WriteLine(encodedString); 
        }



        //операции A < B, A <= B, B > A, B >= A, който проверяват дали A e subset на B, т.е. масивът,
        //base64-кодиран от низа A е subset на низа, base64-кодиран в низа B. 
        public static bool operator <(MyBase64 left, MyBase64 right)
        {
            if (right.encodedString.Contains(left.encodedString))
            {
                return true;
            }
            else return false;

        }

        public static bool operator >(MyBase64 left, MyBase64 right)
        {
            if (left.encodedString.Contains(right.encodedString))
            {
                return true;
            }
            else return false;
        }


        public static bool operator <=(MyBase64 left, MyBase64 right)
        {
            if (right.encodedString.Contains(left.encodedString) || right.encodedString == left.encodedString)
            {
                return true;
            }
            else return false;

        }


        public static bool operator >=(MyBase64 left, MyBase64 right)
        {
            if (left.encodedString.Contains(right.encodedString) || right.encodedString == left.encodedString)
            {
                return true;
            }
            else return false;
        }
    }
}
