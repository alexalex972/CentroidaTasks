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
            xmlAttribute id = new xmlAttribute("id", "0");

            person.addAttribute(id);
            person.addChild(name);
            person.addChild(address);
            people.addChild(person);

            people.printXml();
            
            Console.ReadLine();
             

            
        }
    }
}
