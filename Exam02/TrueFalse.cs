using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class TrueFalse : Questions
    {
        public TrueFalse(string header, string body, double mark, Answer[] answers, Answer correctAnswer) : base(header, body, mark, answers, correctAnswer)
        {
        }
    }
}
