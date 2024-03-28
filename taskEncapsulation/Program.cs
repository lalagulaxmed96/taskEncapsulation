namespace taskEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Library libary = new Library();
                       
            Book book1 = new Book(12, 5, 1, "Firuze");
            Book book2 = new Book(10.20, 5, 2, "Heyat");
            Book book3 = new Book(8, 15, 3, "Melek");
            Book book4 = new Book(4.70, 11, 4, "Tarix");

            libary.AddBook(book1);
            libary.AddBook(book2);
            libary.AddBook(book3);
            libary.AddBook(book4);


            libary.ShowAllBooks();





        }
    }
}
