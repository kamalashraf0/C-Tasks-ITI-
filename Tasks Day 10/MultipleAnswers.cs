using System.Text;

namespace Tasks_Day_10
{
    public class MultipleAnswers : Questions
    {
        public List<string> Options { get; set; }

        public MultipleAnswers(string _body, int _marks, string _header, List<string> _options) : base(_body, _marks, _header)
        {
            Options = _options;
        }



        public static List<Questions> ModelQuestions()
        {
            return new()
            {
                new MultipleAnswers("Volkswagen group have :  ", 8, "Q1) Choose Multiple answers  ", [" a) BMW ", " b) Porsche ", " c) Audi", " d) Bentley "]),
                new MultipleAnswers("Volkswagen group have :  ", 8, "Q2) Choose Multiple answers  ", [" a) BMW", " b) Porsche ", " c) Audi ", " d) Bentley "]),

            };
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string option in Options)
            {
                sb.AppendJoin(" ,", option);

            }
            return $"{Header} :\n {Body} \tOptions: {sb} \t\t({Marks})Marks   \n\t Enter The Answer separated by , like => a,b,c";

        }

    }
}
