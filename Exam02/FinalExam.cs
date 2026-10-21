using System;
using System.Collections.Generic;
using System.Text;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int noOfQuestions, Questions[] questions) : base(time, noOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("----- FINAL EXAM -----");
            Console.WriteLine($"Time: {Time} minutes");
            Console.WriteLine($"Number of Questions: {NoOfQuestions}");
            Console.WriteLine();

            double totalGrade = 0;

            foreach (Questions q in Questions)
            {
                Console.WriteLine($"{q.Header}");
                Console.WriteLine($"{q.Body}");
                Console.WriteLine($"Mark: {q.Mark}");

                Console.WriteLine("Answers:");

                foreach (Answer answer in q.Answers)
                {
                    Console.WriteLine(answer);
                }

                Console.WriteLine();

                totalGrade += q.Mark;
            }

            Console.WriteLine();
            Console.WriteLine($"Total Grade: {totalGrade}");
        }
    }
}
