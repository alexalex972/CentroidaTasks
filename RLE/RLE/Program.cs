using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //input this -> AAAABBBBCCCAABBBB
            string initialString = Console.ReadLine();

            List<string> encodedString = RLE(initialString);

            Console.WriteLine("Encoded: ");
            
            foreach (string item in encodedString)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Decoded: ");
           
            Console.WriteLine(deRLE(encodedString));

            Console.WriteLine("\n");
            List<string> insertionString = new List<string>()
             {
                 "3,C","1,B"
             };
           
            Console.WriteLine("After Insertion: ");
            foreach (string item in insert(encodedString, insertionString, 6))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine("After Deletion: ");
            
             foreach (string item in delete(encodedString, 6, 8))
             {
                 Console.WriteLine(item);
             }
            Console.WriteLine("\n");

            Console.WriteLine("Frequency Table: ");
           
            foreach (string item in freqTable(encodedString))
           {
               Console.WriteLine(item);
           }

            Console.ReadLine();
        }

        public static List<string> RLE(string initialString) //кодират даден низ в RLE списък  
        {
            
            List<string> RLE = new List<string>();

            int i = 0;
            char key = ' ';
            int counter = 1;
            while(i< initialString.Length-1)
            {
                key = initialString[i];
                i++;
                while(key == initialString[i] && i < initialString.Length-1)
                {
                    counter++;
                    i++;
                }
                if (i == initialString.Length - 1 && key == initialString[i]) counter++;
                RLE.Add(counter.ToString() + "," + key);
                counter = 1;
            }

            return RLE;

        }

        public static string deRLE(List<string> encoded) // декодират RLE списък до низ 
        {
            string decoded = "";
            int lenghtOFcode = 0;
            char keySymbol = ' ';

           for(int i =0; i<encoded.Count(); i++)
            {
                
                lenghtOFcode =  (int)Char.GetNumericValue(encoded[i][0]);
                keySymbol = encoded[i][2];
                
                while(lenghtOFcode >0)
                {
                    decoded = decoded + keySymbol;
                    lenghtOFcode--;
                }
    
            }
            return decoded;
        }

        public static List<string> insert(List<string> encoded1, List<string> encoded2, int position) // вмъкват един RLE списък на произволна позиция в друг, като позицията се указва в брой символи от началото на оригиналния низ 
        {

            string decoded1 = deRLE(encoded1);
            string decoded2 = deRLE(encoded2);

            decoded1 = decoded1.Insert(position, decoded2);
            

            return RLE(decoded1);
        }

        public static List<string> delete(List<string> encoded1, int positionToStart, int positionsToDelete) //изтриват последователност от символи от RLE списък 
        {

            string decoded1 = deRLE(encoded1);


            decoded1 = decoded1.Remove(positionToStart, positionsToDelete);


            return RLE(decoded1);
        }

        //public static bool subSTR(List<string> subString, List<string> encoded)
        
        public static List<string> freqTable(List<string> encoded1) //  честотната таблица
        {
            int counter;
            char key;
            int i = 0;
            List<string> frequency = new List<string>();
            while (i<encoded1.Count())
            {
                key = encoded1[i][2];
                counter = (int)Char.GetNumericValue(encoded1[i][0]);
                int j =i+1;
                while(j < encoded1.Count())
                {
                    if(encoded1[j][2] == key)
                    {
                        counter = counter + (int)Char.GetNumericValue(encoded1[j][0]);
                        encoded1.RemoveAt(j);
                    }
                    j++;
                }
                frequency.Add(counter.ToString() + "," + key);
                i++;
            }

            return frequency;

            

        }


    }
}
