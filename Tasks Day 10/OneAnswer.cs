using System.Text;

namespace Tasks_Day_10
{
    public class OneAnswer : Questions
    {
        public List<string> Options { get; set; }
        public OneAnswer(string _body, int _marks, string _header, List<string> _options) : base(_body, _marks, _header)
        {
            Options = _options;
        }



        public static List<Questions> ModelQuestions()
        {
            return new()
            {
                new OneAnswer("What are the .NET programming language? ", 5, " Q1) Choose One answer  ", [" a) CSharp ", " b) JAVA ", " c) Python "]),
               new OneAnswer("What are the .NET programming language? ", 5, " Q2) Choose One answer  ", [" a) CSharp ", " b) JAVA ", " c) Python "]),

            };
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string option in Options)
            {
                sb.Append($"{option}");
            }
            return $"{Header} :\n {Body} \tOptions: {sb} \t\t({Marks})Marks \n\t\t\t Choose[a or b or c]";

        }

    }
}
