using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_second
{
    interface Question
    {
        void ask();
        int grade();
    }


    public class YesNoQuestion : Question
    {
        private string _question;
        private bool _answer;
        private int _points;
        private bool attAnswer;

        public YesNoQuestion(string q, bool a, int p)
        {
            _question = q;
            _answer = a;
            _points = p;
        }

        public void ask()
        {
            Console.WriteLine("Question: " + _question + "? Answer with true or false");
            attAnswer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\n");
        }

        public int grade()
        {
            if(attAnswer != _answer)
            {
                _points = 0;
            }

            return _points;
        }
    }

    public class MultipleChoice : Question
    {
        string[] possibleAnswers;
        private string _question;
        private string _answer;
        private int _points;
        private string attAnswer;

        public MultipleChoice(string q, string a, int p, string[] aP)
        {
            _question = q;
            _answer = a;
            _points = p;
            possibleAnswers = aP;
        }

        public void ask()
        {
            Console.WriteLine("Question: " + _question + "? Answer like this a(choosing a) a,b(choosing a and b! ");
            foreach (string item in possibleAnswers)
            {
                Console.WriteLine(item);
            }


            attAnswer = Console.ReadLine();
            Console.WriteLine("\n");
        }

        public int grade()
        {
            int new_points = 0;
            if (attAnswer == _answer)
            {
                if (_answer.Length > 1)
                {
                    

                    foreach (char item in _answer)
                    {
                        new_points = new_points + _points;
                    }
                }
            }
            else
            {
                new_points = 0;
            }
           
            return new_points;
        }
 
    }

    public class OpenQuestion : Question
    {
        private string _question;
        private int _points;
        private string attAnswer;

        public OpenQuestion(string q, int p)
        {
            _question = q;
            _points = p;
        }

        public void ask()
        {
            Console.WriteLine("Question: "+ _question +"? Write your answer: ");
            attAnswer = Console.ReadLine();
            Console.WriteLine("\n");
        }

        public int grade()
        {
            if (attAnswer.Length == 0)
            {
                _points = 0;

            }
            else if (attAnswer.Length == attAnswer.Length / 2)
            {
                _points = _points / 2;
            }
            else if (attAnswer.Length == attAnswer.Length)
            {
                
            }
            else if (attAnswer.Length < attAnswer.Length / 2)
            {
                _points = _points / 3;
            }
            else
            {
                _points = _points + _points / 3;
            }

            return _points;
        }
    }
    
}
