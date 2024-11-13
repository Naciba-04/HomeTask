namespace LibraryMicroTask
{
    public class Book
    {
        public int Id {  get; set; }   
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        //public Book(int id, string title, string authorname, decimal price)
        //{
        //    this.Id = id;
        //    this.Title = title;
        //    this.AuthorName = authorname;
        //    this.Price = price;
        //}
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id},Title:{Title},AuthorName:{AuthorName},Price:{Price}");
        }
    }
}
