namespace Tasks_Day_11
{
    public class Book
    {

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }


        public Book()
        {

        }

        public Book(string _ISBN, string _Title,
            string[] _Authors, DateTime _PublicationDate,
            decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;

        }





        public override string ToString()
        {
            var Auth = string.Join(",", Authors);

            return $"{ISBN}\t{Title}\t{Auth}\t\t{PublicationDate.ToShortDateString()}\t{Price}\n";



        }






    }
}
