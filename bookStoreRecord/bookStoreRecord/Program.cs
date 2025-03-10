namespace bookStoreRecord
{
    internal class Program
    {
        public record BookStore(int id, string title, string author, double price)
        {
            static void Main(string[] args)
            {
                BookStore book = new(20, "Manhatten", "Marthalamew", 20.38);
                BookStore book1 = new(28, "Liverashy", "Lamnathan", 28.79);
                BookStore book2 = new(50, "Virtue of Songs", "Vinmar", 50.99);
                Console.WriteLine($"For the {book.id} record, the title is {book.title}, the author is {book.author}, and it has a price of {book.price:C2}.");
                Console.WriteLine($"For the {book1.id} record, the title is {book1.title}, the author is {book1.author}, and it has a price of {book1.price:C2}.");
                Console.WriteLine($"For the {book2.id} record, the title is {book2.title}, the author is {book2.author}, and it has a price of {book2.price:C2}.");
            }
        }
    }
}
