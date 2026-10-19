using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal abstract class Exam
    {
       
        protected Exam(int time, int noOfQuestions , Questions[] questions)
        {
            Time = time;
            NoOfQuestions = noOfQuestions;
            Questions = questions;
        }

        public int Time { get; set; }
        public int NoOfQuestions { get; set; }
        public Questions[] Questions { get; set; }

        public abstract void ShowExam();
    }
}
