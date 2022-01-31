namespace P14ForLoops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("From 1 to 1000");
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("From 200 to 100");
            for (int i = 200; i >= 100; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("From 1024 to 1");
            for (int i = 1024; i >= 1; i /= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

