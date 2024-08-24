namespace _04_Prototype;

internal class Book
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;

    private string author { get; set; }

    public Book(string author)
    {
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public Book Clone()
    {
        Book book = (Book) this.MemberwiseClone();
        return book;
    }
}
