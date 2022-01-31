namespace P1Methods
{
    class Program
    {
        static void Count(int from, int to)
        {
            Console.WriteLine($"Counting from {from} to {to}");

            if (from > to)
            {
                for (int i = from; i >= to; i--)
                { 
                
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = from; i <= to; i++)
                { 
                
                    Console.WriteLine(i);
                }
            }
            
        }
        static void Main()
        {
            Count(2,3);
            Count(100,101);
            Count(10,8);
            Count(1,-1);
            Count(1337,1337);
        }
    }
}

