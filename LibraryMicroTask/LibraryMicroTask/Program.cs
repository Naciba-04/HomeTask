using Newtonsoft.Json;

namespace LibraryMicroTask;

internal class Program
{
    static void Main(string[] args)
    {
        string path = Path.Combine(@"C:\Users\resul\Desktop\hometask\LibraryMicroTask\LibraryMicroTask\FileFolder\Database.json");
        if (!File.Exists(path))
        {
            File.Create(path);
        }

        Console.Write("Kitabin Id-ni daxil et.");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Kitabin Adini daxil et.");
        string title = Console.ReadLine();
        Console.Write("Kitabin Muellifinin Adini daxil et.");
        string author = Console.ReadLine();
        Console.Write("Kitabin Qiymetini daxil et.");
        decimal price = decimal.Parse(Console.ReadLine());

        Book newbook = new Book
        {
            Id = id,
            AuthorName = author,
            Price = price,
            Title = title
        };
        ////1 - ci Emeliyyat
        //FileHelper fh = new FileHelper(@"C:\Users\resul\Desktop\hometask\LibraryMicroTask\LibraryMicroTask\FileFolder\Database.json");
        //Library lbr = new Library
        //{
        //    Id = 1,
        //    Name = "Kitabxana"
        //};
        //lbr.AddBook(newbook);
        //List<Book> Books = [newbook];
        //string result = JsonConvert.SerializeObject(Books);
        //fh.AppendAsync(result).Wait();

        ////2 - ci Emeliyyat
        //FileHelper fh = new FileHelper(@"C:\Users\resul\Desktop\hometask\LibraryMicroTask\LibraryMicroTask\FileFolder\Database.json");
        //string bookstr = fh.ReadAsync().Result;
        //var list = JsonConvert.DeserializeObject<List<Book>>(bookstr);
        //Library lbr = new Library
        //{
        //    Id = 1,
        //    Name = "Kitabxana"
        //};
        //lbr.AddBook(newbook);
        //lbr.GetBookById(id);
        //newbook.ShowInfo();
        //List<Book> Books = [newbook];
        //string result = JsonConvert.SerializeObject(Books);
        //fh.ReplaceAsync(result).Wait();

        //3 - ci Emeliyyat
        //FileHelper fh = new FileHelper(@"C:\Users\resul\Desktop\hometask\LibraryMicroTask\LibraryMicroTask\FileFolder\Database.json");
        //string bookstr = fh.ReadAsync().Result;
        //var list = JsonConvert.DeserializeObject<List<Book>>(bookstr);
        //Library lbr = new Library
        //{
        //    Id = 1,
        //    Name = "Kitabxana"
        //};
        //lbr.AddBook(newbook);
        //lbr.GetBookById(id);
        //lbr.RemoveBook(id);
        //Console.WriteLine("Kitab silindi.");
        //newbook.ShowInfo();
        //List<Book> Books = [newbook];
        //string result = JsonConvert.SerializeObject(Books);
        //fh.ReplaceAsync(result).Wait();
        


        }
    }
