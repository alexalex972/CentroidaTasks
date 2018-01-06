using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_s_Complement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                a = Int32.Parse(Console.ReadLine());
                if (a < 0 || a > 100000) // Constraints 
                {
                    Console.Write("Please Input a number between 0 and 100 000 inclusive!");
                    Console.Write('\n');
                }
                else
                {
                    Console.Write("The complement is: " + getIntegerComplement(a));
                    Console.Write('\n');
                }
                Console.Write("Input a number: (Press Esc to exit!)");
                Console.Write('\n');
                

                
               

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
        }

        public static int getIntegerComplement(int number) 
        {
            string binaryNumber = Convert.ToString(number, 2); // the Convert.ToString function converts the given number
                                                               // to the base passed as a second parameter in this case 2  
            string complement = ""; 

            

            int binaryNumberSize = binaryNumber.Length;

            for(int i =0; i< binaryNumberSize; i++)
            {
                if (binaryNumber[i] == '0') // going through all elements in the binary representation of the number
                                            // I add to the opposite to the complement's string and therefore getting the complement
                {
                    complement = complement + "1";
                }
                else
                    complement = complement + "0";
            }

            number = Convert.ToInt32(complement, 2); // Convert.ToInt32 converts the complement string from binary to decimal


            return number;
        }
    }
}
