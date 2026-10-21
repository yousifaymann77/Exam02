using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal abstract class Questions : IComparable<Questions>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        public Answer[] Answers { get; set; }
        public Answer CorrectAnswer { get; set; }

        protected Questions(string header, string body, double mark, Answer[] answers, Answer correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            string result = $"{Header}\n{Body}\nMark: {Mark}\n";

            foreach (Answer ans in Answers) 
            {
                result += ans + "\n";
            }
            return result ; 
        }

        public int CompareTo(Questions other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }
    }
}
