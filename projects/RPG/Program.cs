
public class Unit
{
    private int maxHealth;
    private int health;
    private string name;
    private int id;
    private static int nextId;
    
    public Unit(string name, int maxHealth)
    {
        this.maxHealth = maxHealth;
        this.name = name;
        id = nextId;
        health = maxHealth;
        nextId++;
        ReportStatus();
    }
   public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name} - {health}/{maxHealth} Health");
    }

   public void SetHealth(int newHealth)
   {
       health = Math.Clamp(newHealth, 0 ,this.maxHealth);
       ReportStatus();
   }
    
   ~Unit()
   {
       Console.WriteLine($"Unit #{id}: {name} got finalized.");
   }
}

class Program
{
    static void Main()
    {
        Unit zombie = new Unit("Zombie", 100);
        Unit vampire = new Unit("Vamprie",200);
        Unit evilCat = new Unit("Evil Cat",50);
        Unit leet = new Unit("Leet", 1337);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("What do you want Leet's Health to be?");
            int newHP = Convert.ToInt32(Console.ReadLine());
            leet.SetHealth(newHP);
        }


    }
}