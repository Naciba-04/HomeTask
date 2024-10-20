
namespace AccessModifiers
{
    class Song
    {
        private string _name;
        private string _genre;
        public Singer singer { get; set; }
        public float[] ratings=new float[10];
        public int ratingCount=0 ;
              
       public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 100)
                   
                _name = value;
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (value=="Pop" && value=="Rock" && value=="Jazz" && value=="Techno")
                   
                _genre = value;
            }
        }

        public void AddRating(float rating)
        {
            if (ratingCount < ratings.Length)
            {
                ratings[ratingCount] = rating;
                ratingCount++;
            }
            else
            {
                Console.WriteLine("Reytinq limiti dolub!");
            }
                     
        }
        public float GetAverageRating()
        {
            if (ratingCount==0)
                 return 0;
            float sum = ratings.Sum();
            return sum / ratingCount;


        }
    }
}
