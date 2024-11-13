namespace LibraryMicroTask;

public class Library
{
    public int Id { get; set; }
    public string Name { get; set; }
    List<Book>Books=new List<Book>();
    //public Library(int id, string name)
    //{
    //    this.Id = id;
    //    this.Name = name;
    //}
    public void AddBook(Book book)
    { 
    Books.Add(book);
    }
    public Book GetBookById(int id)
    {
        return Books.Find(b => b.Id == id);
    }
    public void RemoveBook(int id)
    { 
        Books.RemoveAll(b => b.Id == id);
    }
}





