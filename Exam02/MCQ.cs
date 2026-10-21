using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class MCQ : Questions ,ICloneable
    {
        public MCQ(string header, string body, double mark, Answer[] answers, Answer correctAnswer) : base(header, body, mark, answers, correctAnswer)
        {
        }
        public object Clone()
        {
            Answer[] copiedAnswers = new Answer[Answers.Length];

            for (int i = 0; i < Answers.Length; i++)
            {
                copiedAnswers[i] = (Answer)Answers[i].Clone();
            }

            Answer copiedRightAnswer = null;

            for (int i = 0; i < Answers.Length; i++)
            {
                if (ReferenceEquals(Answers[i], CorrectAnswer))
                {
                    copiedRightAnswer = copiedAnswers[i];
                    break;
                }
            }

            return new MCQ(
                Header,
                Body,
                Mark,
                copiedAnswers,
                copiedRightAnswer);
        }
    }
}
