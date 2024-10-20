namespace AccessModifiers
{
    class Program
    {
        static void Main()
        {
          

            Singer singer1 = new Singer
            {
                Name = "Tamino",
                Surname = "Amir",
                Age = 27

            };

            Song song = new Song
            {
                Name = "Indigo Night",
                Genre = "Jazz",

            };
            
            song.AddRating(8.7f);
            song.AddRating(6.5f);
            song.AddRating(7.2f);

            float avarege = song.GetAverageRating();
            Console.WriteLine("Average rating" + " " + avarege);


            
        }
    }
}
