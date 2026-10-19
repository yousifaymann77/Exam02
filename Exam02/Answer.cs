using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int answerId , string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public override string ToString()
        {
            return $"AnswerId: {AnswerId}, AnswerText: {AnswerText}";
        }

    }
}
