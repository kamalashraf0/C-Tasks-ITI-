namespace Tasks_Day_10
{
    public class Questions
    {


        public string Body { get; set; }

        public int Marks { get; set; }

        public string Header { get; set; }


        public Questions(string _body, int _marks, string _header)
        {

            Body = _body;
            Marks = _marks;
            Header = _header;

        }

        public override string ToString()
        {
            return $"{Header} : {Body} \t({Marks}Marks)";
        }

        public override bool Equals(object? obj)
        {

            var question = obj as Questions;

            if (question == null) return false;

            if (question.GetType() != this.GetType()) return false;

            if (object.ReferenceEquals(question, this)) return true;

            return this.Header == question.Header && this.Body == question.Body && this.Marks == question.Marks;

        }

    }


}
