namespace GenericTask;

public abstract class Animal
{
    public int AvgLifeTime { get; set; }
    public Gender AnimalGender { get; set; }
    public string Breed { get; set; }
    public int HP { get; set; }

    public Animal(int avgLifeTime, Gender animalGender, string breed, int hp)
    {
        this.AvgLifeTime = avgLifeTime;
        this.AnimalGender = animalGender;
        this.Breed = breed;
        this.HP = hp;
    }
}
public class Wolf : Animal
{
    public bool IsPrideLeader { get; set; }
    public int AttackDamage { get; set; }
    public Wolf(int avgLifeTime, Gender animalGender, string breed, int hp, bool isPrideLeader, int atackDamage)
        : base(avgLifeTime, animalGender, breed, hp)
    {
        this.IsPrideLeader = isPrideLeader;
        this.AttackDamage = atackDamage;
    }

    public void Hunt<T>(T animal) where T : Animal
    {
        animal.HP -= AttackDamage;
        if (animal.HP < 0)
        {
            animal.HP = 0;
        }
        Console.WriteLine($"{Breed} hucum edir {animal.Breed}-e,{animal.Breed}-in HP-si {animal.HP}");

    }
}
public class Elephant : Animal
{
    public double Weight { get; set; }
    public bool IsTrained { get; set; }
    public Elephant(int avgLifeTime, Gender animalGender, string breed, int hp, double weight, bool isTrained) : base(avgLifeTime, animalGender, breed, hp)
    {
        this.Weight = weight;
        this.IsTrained = isTrained;
    }
}
