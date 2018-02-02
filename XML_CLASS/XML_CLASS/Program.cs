using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {

            
             
            xmlElement people = new xmlElement("people");

            xmlElement person = new xmlElement("person");
            xmlElement name = new xmlElement("name");
            xmlElement address = new xmlElement("address");
            xmlAttribute id = new xmlAttribute("id");
            person.addAttribute(id);
            person.addChild(name);
            person.addChild(address);

            xmlElement person1 = new xmlElement("person");
            xmlElement name1 = new xmlElement("name");
            xmlElement address1 = new xmlElement("address");
            xmlAttribute id1 = new xmlAttribute("id");
            person1.addAttribute(id1);
            person1.addChild(name1);
            person1.addChild(address1);

            xmlElement person2 = new xmlElement("person");
            xmlElement name2 = new xmlElement("name");
            xmlElement address2 = new xmlElement("address");
            xmlAttribute id2 = new xmlAttribute("id");
            person2.addAttribute(id2);
            person2.addChild(name2);
            person2.addChild(address2);

            name._value = "John Smith";
            name1._value = "Ivan Petrov";
            address._value = "USA";
            address1._value = "Bulgaria";
            name2._value = "Alex Mishev";
            address2._value = "USA";



            people.addChild(person);
            people.addChild(person1);
            people.addChild(person2);

            /*foreach (string a in people/"address")
            {
                Console.WriteLine(a);
            }  */

            //person.deleteAtt("id");
            people.Enumerate();
            people.printXml();


            Console.ReadLine();

            Console.WriteLine("People from USA:");
            people.search("USA");

            Console.ReadLine();
             

            
        }
    }
}
