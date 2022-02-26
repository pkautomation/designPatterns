
using _04_Prototype;

var book = new Book("lenin");
book.Name = "Once upon a time";
book.Title = "some title";

var book2 = book.Clone();

Console.WriteLine("book information:");
Console.WriteLine("name:" + book2.Name);
Console.WriteLine("title:" + book2.Title);
Console.WriteLine("author:" + book2.GetAuthor());
