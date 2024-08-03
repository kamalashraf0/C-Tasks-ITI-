namespace Tasks_Day_10
{
    public abstract class Exam
    {
        public int NoOfQuestions { get; set; }

        public int FinalGrade { get; set; }

        public Dictionary<List<Questions>, List<string>> LQuestionAnswer { get; set; }


        public Exam(int _noOfQuestions, int _finalgrade, Dictionary<List<Questions>, List<string>> _lquestionAnswer)
        {
            NoOfQuestions = _noOfQuestions;
            FinalGrade = _finalgrade;
            LQuestionAnswer = _lquestionAnswer;
        }

        public abstract void ShowExamList();



    }
}
