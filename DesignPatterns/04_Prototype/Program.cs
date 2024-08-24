using _04_Prototype;

var book = new Book("lenin");
book.Name = "Once upon a time";
book.Title = "some title";

var book2 = book.Clone();

PrintBookInformation(book);
PrintBookInformation(book2);

static void PrintBookInformation(Book book)
{
    Console.WriteLine("book information:");
    Console.WriteLine("name:" + book.Name);
    Console.WriteLine("title:" + book.Title);
    Console.WriteLine("author:" + book.GetAuthor());
    Console.WriteLine();
}
