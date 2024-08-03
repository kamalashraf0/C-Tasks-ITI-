namespace Tasks_Day_10
{
    public class Answers
    {
        public List<string> LAnswer { get; set; }

        public Answers(List<string> _lanswer)
        {
            LAnswer = _lanswer;
        }


        public static List<string> TandFAnswers()
        {
            return new(["False", "True"]);
        }

        public static List<string> ChooseOneAnswers()
        {
            return ["a", "a"];

        }

        public static List<string> ChooseMultipleAnswers()
        {
            return new(["b,c,d", "b,c,d"]);

        }

    }
}
