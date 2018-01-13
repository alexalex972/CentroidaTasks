using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OOP_second
{
    class Test
    {

        public List<Question> test = new List<Question>();

        public void addQuestion(string questionName, string q, int p, [Optional] object a, [Optional] string[] aP)
        {
            if (questionName == "Yes/No Question")
            {
                YesNoQuestion quest1 = new YesNoQuestion(q, Convert.ToBoolean(a), p);
                test.Add(quest1);
            }
            if (questionName == "Multiple Choice Question")
            {
                string answer1 = Convert.ToString(a);
                MultipleChoice quest2 = new MultipleChoice(q, answer1, p, aP);
                test.Add(quest2);
            }
            if (questionName == "Open Question")
            {
                OpenQuestion quest3 = new OpenQuestion(q, p);
                test.Add(quest3);
            }

        }

        public void doTest()
        {
            foreach (Question item in test)
            {
                item.ask();
            }
        }

        public int gradeTest()
        {
            int score = 0;

            foreach (Question item in test)
            {
                
                score = score + item.grade();
            }

            return score;
        }

    }
}
