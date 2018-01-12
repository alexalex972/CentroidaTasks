using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    
    public abstract  class Question<T> 
    {
            public string question { get; set; }
            public T answer { get; set; }
            public int points { get; set; }

            public abstract void ask();
            public abstract void grade();

    }

    public class YesNoQuestion : Question<bool>
    {

        public YesNoQuestion(string q, bool a, int p)
        {
            question = q;
            answer = a;
            points = p;
        }

        public override void ask()
        {


        }

        public override void grade()
        {

        }

    }

    public class MultipleChoice : Question<char[]>
    {
        string[] possibleAnswers { get; set; }

        public MultipleChoice(string q, char[] a , int p, string[] aP)
        {
            question = q;
            answer = a;
            points = p;
            possibleAnswers = aP;
        }

        public override void ask()
        {


        }

        public override void grade()
        {

        }

    }

    public class OpenQuestion : Question<string>
    {

            public OpenQuestion(string q, int p)
            {
            question = q;
            points = p;   
            }

        public override void ask()
        {


        }

        public override void grade()
        {

        }

    }

}
