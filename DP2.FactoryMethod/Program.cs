// Sử dụng factory để tạo ra các đối tượng sách
using DP2.FactoryMethod;

public class BookManager
{
    static void Main(string[] args)
    {
        CreateAndDisplayBooks();
    }
    public static void CreateAndDisplayBooks()
    {
        IBook novel = BookFactory.CreateBook(BookFactory.BookType.Novel);
        IBook technicalBook = BookFactory.CreateBook(BookFactory.BookType.Technical);

        Console.WriteLine(novel.GetBookDetails());
        Console.WriteLine(technicalBook.GetBookDetails());
    }
}
