namespace Tasks_Day_10
{
    public class PracticeExam : Exam
    {


        public PracticeExam(int _noOfQuestions, int _finalgrade, Dictionary<List<Questions>, List<string>> _questionAnswer)
            : base(_noOfQuestions, _finalgrade, _questionAnswer)
        {
        }


        public override void ShowExamList()
        {
            int count = 0;
            int grade = 0;


            foreach (var item in LQuestionAnswer)
            {
                int questionIndex = 0;
                foreach (var question in item.Key)
                {
                    Console.WriteLine(question);

                    Console.Write("Your answer: ");
                    string userAnswer = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(userAnswer))
                    {
                        Console.Write("Your answer: ");
                        userAnswer = Console.ReadLine();
                    }
                    Console.WriteLine("--------------------------------------------------");

                    string correctAnswer = item.Value[questionIndex];

                    if (userAnswer.ToLower() == correctAnswer.ToLower())
                    {
                        count++;
                        grade += question.Marks;
                    }
                    questionIndex++;
                }
            }
            Console.WriteLine("For Model Answer : Press Enter..... ");
            Console.ReadKey();
            Console.WriteLine("████████████████████████████████████");
            Console.WriteLine("Model Answer :   ");
            Console.WriteLine("████████████████████████████████████");

            foreach (var item in LQuestionAnswer)
            {
                for (int i = 0; i < item.Key.Count; i++)
                {
                    var question = item.Key[i];
                    var correctAnswer = item.Value[i];

                    Console.WriteLine(question);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine($"Correct answer: {correctAnswer}");
                    Console.WriteLine("--------------------------------------------------");
                }

            }
            Console.WriteLine($"You got {count} Correct Answers / {NoOfQuestions} Questions ");
            Console.WriteLine($"Your Final Grade is {grade} / {FinalGrade} ");
        }

    }

}
