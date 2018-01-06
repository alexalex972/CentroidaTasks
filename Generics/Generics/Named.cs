using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named
{
    public class Named<T>
    {
        public T value { get; set; }
        public string name { get; set; }
    }
    public class Variable<T> : Named<int>
    {

        public static void swapValue(Variable<T> left, Variable<T> right) // oprator = cannot be overloaded
        { // операция =, която присвоява стойността на една променлива на друга без да променя името
            left.value = right.value;
        }

        public static void showValue(Variable<T> i)
        // едноместна операция *, която връща стойността на променливата
        {

            Console.WriteLine(i.value);
        }


        // операции == и !=, които сравняват две променливи
        public static bool operator ==(Variable<T> left, Variable<T> right)
        {
            if (left.value == right.value && left.name == right.name)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Variable<T> left, Variable<T> right)
        {
            if (left.value == right.value && left.name == right.name)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    // Клас за extension methods, в който да се имплементират extension методи
    // за задаване на стойността на променливата и извеждането и на конзолата.

    public static class Extension
    {

        public static void setValue(this Variable<int> var, int x)
        {

            var.value = x;

        }

        public static void getValue(this Variable<int> var)
        {

            Console.WriteLine(var.value);

        }

    }

}