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
            name.value = "John Smith";
            xmlElement address = new xmlElement("address");
            address.value = "USA";
            xmlAttribute id = new xmlAttribute("id", 1);

            person.addAttribute(id);
            person.addChild(name);
            person.addChild(address);
            people.addChild(person);

            xmlElement person1 = new xmlElement("person");
            xmlElement name1 = new xmlElement("name");
            name1.value = "Ivan Petrov";
            xmlElement address1 = new xmlElement("address");
            address1.value = "Bulgaria";
            xmlAttribute id1 = new xmlAttribute("id",2);

            person1.addAttribute(id1);
            person1.addChild(name1);
            person1.addChild(address1);
            people.addChild(person1);


            xmlElement person2 = new xmlElement("person");
            xmlElement name2 = new xmlElement("name");
            name2.value = "Alex Mishev";
            xmlElement address2 = new xmlElement("address");
            address1.value = "Romania";
            xmlAttribute id2 = new xmlAttribute("id", 2);

            person2.addAttribute(id2);
            person2.addChild(name2);
            person2.addChild(address2);
            people.addChildAt(person2,2);
            people.deleteChildAt(2);

            //person.deleteAtt("id");
            people.Enumerate();
            people.printXml();
            
            Console.ReadLine();
             

            
        }
    }
}
