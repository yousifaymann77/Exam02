using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class Subject
    {
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }


        public void CreateExam(string exType , int time , Questions[] questions)
        {
            if (exType == "final")
            {
                Exam = new FinalExam(time, questions.Length, questions);
            }
            else if (exType == "practical")
            {
                int count = 0;

                for (int i = 0; i < questions.Length; i++)
                {
                    if (questions[i] is MCQ)
                    {
                        count++;
                    }
                }

                MCQ[] mcqQuestions = new MCQ[count];

                int index = 0;

                for (int i = 0; i < questions.Length; i++)
                {
                    if (questions[i] is MCQ)
                    {
                        mcqQuestions[index] = (MCQ)questions[i];
                        index++;
                    }
                }

                Exam = new PracticalExam(
                    time,
                    mcqQuestions.Length,
                    mcqQuestions);
            }
            else
            {
                throw new Exception("Invalid Exam Type");
            }
        }
    }
}
