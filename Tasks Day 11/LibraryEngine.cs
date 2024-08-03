namespace Tasks_Day_11
{
    public delegate string BookDeleagte(Book b);
    public static class LibraryEngine
    {




        public static void FilterByAnyV1(List<Book> bList, string title, BookDeleagte predicate)
        {

            Console.WriteLine(title);
            Console.WriteLine("███████████████████████████████████");

            foreach (var item in bList)
            {


                Console.WriteLine(predicate(item));


            }

        }



        public static void FilterByAnyV2(List<Book> bList, string title, Func<Book, string> predicate)
        {

            Console.WriteLine(title);
            Console.WriteLine("███████████████████████████████████");

            foreach (var item in bList)
            {


                Console.WriteLine(predicate(item));


            }

        }


    }
}
