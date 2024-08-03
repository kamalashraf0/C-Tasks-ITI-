namespace Tasks_Day_10
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
            //List<Questions> TOrFlist = new()
            //{
            //    new TrueOrFalse("HTML is a Programming Language?", 2, "Q1"),
            //    new TrueOrFalse("JavaScript is a Markup Language", 2, "Q2"),

            //};

            List<Questions> OneAnswerlist = new()
            {
                 new OneAnswer("What are the .NET programming language? ", 5, " Q1) Choose One answer  ", [" a) CSharp ", " b) JAVA ", " c) Python "]),
               new OneAnswer("What are the .NET programming language? ", 5, " Q2) Choose One answer  ", [" a) CSharp ", " b) JAVA ", " c) Python "]),

            };
            List<Questions> MultipleAnswerslist = new()
            {
                new MultipleAnswers("Volkswagen group have :  ", 8, "Q1) Choose Multiple answers  ", [" a) BMW ", " b) Porsche ", " c) Audi", " d) Bentley "]),
                new MultipleAnswers("Volkswagen group have :  ", 8, "Q2) Choose Multiple answers  ", [" a) BMW", " b) Porsche ", " c) Audi ", " d) Bentley "]),

            };


            Answers Lanswer1 = new Answers(["False", "True"]);
            Answers Lanswer2 = new Answers(["a", "a"]);
            Answers Lanswer3 = new Answers(["b,c,d", "b,c,d"]);
            */


            var TOrFlist = TrueOrFalse.ModelQuestions();
            var OneAnswerlist = OneAnswer.ModelQuestions();
            var MultipleAnswerslist = MultipleAnswers.ModelQuestions();



            var TandFAnswers = Answers.TandFAnswers();
            var ChooseOneAnswers = Answers.ChooseOneAnswers();
            var ChooseMultipleAnswers = Answers.ChooseMultipleAnswers();



            var QuestionAnswerlist = new Dictionary<List<Questions>, List<string>>
            {
                { TOrFlist , TandFAnswers},
                { OneAnswerlist , ChooseOneAnswers},
                { MultipleAnswerslist ,ChooseMultipleAnswers},
            };

            var practiceExamlist = new PracticeExam(6, 30, QuestionAnswerlist);
            var FinalExamlist = new FinalExam(6, 30, QuestionAnswerlist);

            Console.Write("Select exam type (1- Practice  2- Final): ");
            bool Loop = true;
            while (Loop)
            {
                if (int.TryParse(Console.ReadLine(), out int examType))
                {

                    switch (examType)
                    {
                        case 1:
                            Console.WriteLine("PracticeExam");
                            Console.WriteLine("-------------------");
                            practiceExamlist.ShowExamList();

                            Loop = false;
                            break;
                        case 2:
                            Console.WriteLine("FinalExam");
                            Console.WriteLine("-------------------");

                            FinalExamlist.ShowExamList();

                            Loop = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input , Please Try Again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input Format");
                }
            }

            Console.ReadKey();
        }


    }
}