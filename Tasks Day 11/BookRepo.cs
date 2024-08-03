namespace Tasks_Day_11
{
    public static class BookRepo
    {
        static List<Book> books = new();

        public static List<Book> Books
        {
            get
            {
                return books = new List<Book>()
            {
                new Book("978-0-12-345678-9", "Book Title 1", new string[] { "Author A" }, new DateTime(2021, 1, 1), 15.99m),
                new Book("978-1-23-456789-0", "Book Title 2", new string[] { "Author B", "Author C" }, new DateTime(2020, 2, 15), 25.99m),
                new Book("978-2-34-567890-1", "Book Title 3", new string[] { "Author D" }, new DateTime(2019, 3, 30), 10.99m),
                new Book("978-3-45-678901-2", "Book Title 4", new string[] { "Author E", "Author F" }, new DateTime(2018, 4, 22), 29.99m),
                new Book("978-4-56-789012-3", "Book Title 5", new string[] { "Author G" }, new DateTime(2022, 5, 5), 18.49m),
                new Book("978-5-67-890123-4", "Book Title 6", new string[] { "Author H" }, new DateTime(2021, 6, 18), 22.99m),
                new Book("978-6-78-901234-5", "Book Title 7", new string[] { "Author I", "Author J" }, new DateTime(2020, 7, 11), 14.99m),
                new Book("978-7-89-012345-6", "Book Title 8", new string[] { "Author K" }, new DateTime(2019, 8, 24), 16.49m),
                new Book("978-8-90-123456-7", "Book Title 9", new string[] { "Author L", "Author M" }, new DateTime(2018, 9, 10), 28.99m),
                new Book("978-9-01-234567-8", "Book Title 10", new string[] { "Author N" }, new DateTime(2022, 10, 20), 12.99m)
            };
            }
        }






        public static List<Book> LoadBooks()
        {
            return new List<Book>()
            {
                new Book{
                    ISBN= "978-0-12-345678-9",
                    Title= "Book Title 1",
                    Authors= new string[] { "Author A" },
                    PublicationDate =  new DateTime(2021, 1, 1),
                     Price= 15.99m
                }


            };
        }











    }
}
