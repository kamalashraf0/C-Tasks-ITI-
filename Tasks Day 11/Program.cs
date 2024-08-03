namespace Tasks_Day_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate


            var books = BookRepo.Books;

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();


            LibraryEngine.FilterByAnyV1(books, "Book Title", new BookDeleagte(BookFunctions.GetTitle));
            Console.WriteLine();

            LibraryEngine.FilterByAnyV1(books, "ISBN", delegate (Book B) { return B.ISBN; });
            Console.WriteLine();


            Func<Book, string> FD = BookFunctions.GetAuthors;
            LibraryEngine.FilterByAnyV2(books, "Authors", FD);
            Console.WriteLine();

            LibraryEngine.FilterByAnyV2(books, "Book ISBN", e => e.ISBN);





            #endregion


            Console.ReadKey();
        }
    }
}
