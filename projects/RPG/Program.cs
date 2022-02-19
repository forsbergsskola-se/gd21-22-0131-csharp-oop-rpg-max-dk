namespace RPG
{
        class Program
    {
        static void Main()
        {
            static Unit SpawnNewUnit()
            {
                Random random = new Random();
                if (random.Next(1, 3) == 1) return new Necromancer("Necromancer", 100);
                else return new Unit("Doge", 150);
            }

            for (int i = 0; i < 3; i++)
            {
                Unit unit = SpawnNewUnit();

                while (unit.IsAlive)
                {
                    Console.WriteLine($"How much damage do you want to deal to the {unit.Name}?");
                    unit.TakeDamage(Convert.ToInt32(Console.ReadLine()));
                }
            }

            Console.WriteLine("Game over");
        }
    }


        
        


    public class Unit
    {
        public string Name { get; }
        public int id { get; }
        private static int nextId;
        public int maxHealth { get; }
        private int health;

        public int Health
        {
            set
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
                else
                {
                    DeathMessage();
                    return false;
                }
            }
        }

        public bool IsDead
        {
            get
            {
                if (!IsAlive) return true;
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
            Console.WriteLine($"Unit #{id}: {name} has spawned!");
            ReportStatus();
        }

        public void ReportStatus()
        {
            Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");
        }

        public void DeathMessage()
        {
            Console.WriteLine($"Unit #{id}: {Name} has died!");
        }

        public virtual void TakeDamage(int value)
        {
            Health -= value;
        }

        ~Unit()
        {
            Console.WriteLine($"Unit #{id}: {Name} got finalized.");
        }
    }








    public class Necromancer : Unit
    {
        public bool hasResurrected;

        public Necromancer(string name, int maxHealth) : base(name, maxHealth)
        {
        }

        private void Ressurect()
        {
            if (IsDead && !hasResurrected)
            {
                hasResurrected = true;
                Console.WriteLine($"Unit #{id}: {Name} has come back from the dead!");
                Health = maxHealth / 2;
                
            }
        }

        public override void TakeDamage(int value)
        {
            base.TakeDamage(value);
            Ressurect();
        }
    }

}