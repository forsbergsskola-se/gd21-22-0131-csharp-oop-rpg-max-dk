public class Unit
{
    public string Name { get; }
    private int id;
    private static int nextId;
    private int maxHealth;
    private int health;

    public int Health
    {
        private set
        {
            health = Math.Clamp(value, 0, maxHealth);
            ReportStatus();
        }
        get => health;
    }

    public bool IsAlive
    {
        get
        {
            if (health > 0) return true;
            else return false;
        }
    }

    public Unit(string name, int maxHealth)
    {
        this.maxHealth = maxHealth;
        this.Name = name;
        id = nextId;
        health = maxHealth;
        nextId++;
        ReportStatus();
    }

    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");
    }

    public void Damage(int value)
    {
        Health -= value;
    }

    ~Unit()
    {
        Console.WriteLine($"Unit #{id}: {Name} got finalized.");
    }
}

class Program
{
    static void Main()
    {
        Unit zombie = new Unit("Zombie", 100);
        Unit vampire = new Unit("Vamprie", 200);
        Unit evilCat = new Unit("Evil Cat", 50);
        Unit leet = new Unit("Leet", 1337);


        while (leet.IsAlive)
        {
            Console.WriteLine("How much damage do you want to deal to Leet?");
            leet.Damage(Convert.ToInt32(Console.ReadLine()));
        }
    }
}