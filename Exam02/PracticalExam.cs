using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public MCQ[] Mcqs { get; set; }
        public PracticalExam(int time, int noOfQuestions, MCQ[] questions) : base(time, noOfQuestions, questions)
        {
            Mcqs = questions;
        }

        public override void ShowExam()
        {
            Console.WriteLine("---- Practical Exam ----");

            foreach (MCQ q in Mcqs)
            {
                Console.WriteLine(q.Header);
                Console.WriteLine(q.Body);

                foreach (Answer answer in q.Answers)
                {
                    Console.WriteLine(answer);
                }

                Console.WriteLine();
            }
        }
        public void ShowCorrectAnswers()
        {
            Console.WriteLine("---- Correct Answers ----");
            foreach (MCQ q in Mcqs)
            {
                Console.WriteLine(q.Header);
                Console.WriteLine($"Correct Answer: {q.CorrectAnswer}");
                Console.WriteLine();
            }
        }
    }
}
