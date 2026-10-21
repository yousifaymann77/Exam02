namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Answer a1 = new Answer(1, "C#");
            Answer a2 = new Answer(2, "Python");
            Answer a3 = new Answer(3, "Java");

            Answer[] mcqAnswers = { a1, a2, a3 };

            MCQ q1 = new MCQ("Question 1","Which language are we studying?",5,mcqAnswers,a1);
            MCQ q3 = new MCQ("Question 3 ", "What is The language for spring boot framework ?", 5, mcqAnswers, a3);

            Answer a4 = new Answer(1, "True");
            Answer a5 = new Answer(2, "False");

            Answer[] tfAnswers = { a4, a5 };

            TrueFalse q2 = new TrueFalse("Question 2","C# is an object-oriented language.",2,tfAnswers,a4);

            Questions[] questions = { q1, q2 , q3};
            MCQ[] practicalQuetsions = { q1 ,q3}; 

            Subject subject = new Subject(1, "Programming");

            subject.CreateExam("final", 60, questions);

            Console.WriteLine($"Subject: {subject.SubjectName}");
            subject.Exam.ShowExam();

            Subject practicalSubject = new Subject(2, "Programming Practical");

            practicalSubject.CreateExam("practical", 30, practicalQuetsions);

            PracticalExam practicalExam =
                (PracticalExam)practicalSubject.Exam;

            Console.WriteLine("\nStudent starts the Practical Exam:");
            practicalExam.ShowExam();

            Console.WriteLine("\nStudent has finished the exam.");
            practicalExam.ShowCorrectAnswers();


            Console.WriteLine("\nComparing question marks:");
            Console.WriteLine(q1.CompareTo(q2));


            MCQ q4 = (MCQ)q1.Clone();

            q4.Body = "Modified question";
            q4.Answers[0].AnswerText = "Modified answer";

            Console.WriteLine(q1.Body);
            Console.WriteLine(q4.Body);

            Console.WriteLine(q1.Answers[0].AnswerText);
            Console.WriteLine(q4.Answers[0].AnswerText);
        }
    }
}
