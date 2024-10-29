namespace GenericTask;

public abstract class Food
{
    public int Calorie { get; set; }
    public Food(int calorie)
    {
        this.Calorie = calorie;
    }
}
public class Meat : Food
{
    public Type MeatType { get; set; }
    public Meat(int calorie, Type meatType) : base(calorie)
    {
        this.MeatType = meatType;
    }
}
public class Grass : Food
{
    public string Name { get; set; }
    public Grass(int calorie, string name) : base(calorie)
    {
        this.Name = name;
    }
}
public class ZooCage<T, U> 
    where T : Animal,new() 
    where U : Food,new()
{
    public T Animal { get; set; }
    public U Food { get; set; }
    
        public ZooCage(T animal, U food)
        {
            this.Animal = animal;
            this.Food = food;
        }
  }


