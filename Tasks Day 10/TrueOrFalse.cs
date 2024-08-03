namespace Tasks_Day_10
{
    public class TrueOrFalse : Questions
    {

        public TrueOrFalse(string _body, int _marks, string _header) : base(_body, _marks, _header)
        {

        }


        public static List<Questions> ModelQuestions()
        {
            return new()
            {
                new TrueOrFalse("HTML is a Programming Language?", 2, "T/F Q1"),
                new TrueOrFalse("JavaScript is a Markup Language", 2, "T/F Q2"),
            };
        }

        public override string ToString()
        {
            return $"{Header} :\n {Body}  [True , False] \t\t({Marks})Marks  ";
        }


    }
}
