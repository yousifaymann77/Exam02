using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int noOfQuestions, Questions[] questions) : base(time, noOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            throw new NotImplementedException();
        }
    }
}
