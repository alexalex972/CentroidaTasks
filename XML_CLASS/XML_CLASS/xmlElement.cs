using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_CLASS
{
    public class xmlElement
    {

        private string elementName; // име на елемента
        private List<xmlElement> subEl = new List<xmlElement>(); // списък от вложени елементи
        private List<xmlAttribute> _attributes = new List<xmlAttribute>(); // списък от атрибути и стойности
        private string _value = ""; // текст

        public xmlElement(string elementN) 
        {
            elementName = elementN;
        }
        
        public List<xmlElement> children
        {
            get { return subEl; }
            set { subEl = value; }
        }

        public string value
        {
            get { return _value; }
            set { _value = value; }
        }

        public List<xmlAttribute> attributes
        {
            get { return _attributes; }
            set { _attributes = value; }
        }

        public void addChild(xmlElement element)
        {
            subEl.Add(element);
        }

        public void addAttribute(xmlAttribute attribute)
        {
            _attributes.Add(attribute);
        }

        public void printXml()
        {
            Console.Write("<" + elementName);
            foreach(xmlAttribute attribute in _attributes)
            {
                Console.Write(" " + attribute.key + "='" + attribute.value + "'");
            }
            if (subEl.Count > 0 || _value.Length > 0)
            {
                if (_value.Length > 0)
                {
                    Console.Write(">");
                    Console.Write(_value);
                }
                else
                {
                    Console.WriteLine(">");
                    Console.Write(_value);
                }

                foreach (xmlElement child in subEl)
                {
                    child.printXml();

                }
                Console.WriteLine("</" + elementName + ">");
            }
            else
            {
                Console.WriteLine("/>");
            }
            
        }


    }

    public class xmlAttribute
    {
        private string _key;
        private string _val;


        public xmlAttribute(string key, string val) 
        {
            _key = key;
            _val = val;
        }

        public string key
        {
            get { return _key; }
            set { _key = value; }
        }

        public string value
        {
            get { return _val; }
            set { _val = value; }
        }
        
    }
}
