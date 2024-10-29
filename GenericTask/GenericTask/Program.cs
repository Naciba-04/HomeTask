namespace GenericTask;

 class Program
{
    static void Main(string[] args)
    {
        Wolf wolf=new Wolf(20,Gender.Female,"White Wolf",100,true,50);
        Elephant elephant = new Elephant(60, Gender.Male, "African Elephant", 200, 7000, false);

        Meat meat = new Meat(2500,Type.Mutton);
        Grass grass = new Grass(200, "Bermuda Grass");

        ZooCage<Wolf, Meat> wolfcage = new ZooCage<Wolf, Meat>(wolf, meat);
        Console.WriteLine($"Qefesde {wolfcage.Animal.Breed} ve yemeyi ucun {wolfcage.Food.MeatType} var");

        ZooCage<Elephant, Grass> elephantcage = new ZooCage<Elephant, Grass>(elephant, grass);
        Console.WriteLine($"Qefesde {elephantcage.Animal.Breed} ve yemeyi ucun  {elephantcage.Food.Name} var");
        wolf.Hunt(elephant);

    }
}
