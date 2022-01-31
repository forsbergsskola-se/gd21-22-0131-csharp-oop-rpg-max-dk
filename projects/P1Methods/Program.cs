namespace P1Methods
{
    class Program
    {
        static void CountUp(int to)
        {
            Console.WriteLine($"Counting from 0 to {to}");
            for (int i = 0; i <= to; i++)
            { 
                Console.WriteLine(i);
            }
        }
        static void CountDown(int from)
        {
            Console.WriteLine($"Counting from {from} to 0");
            for (int i = from; i >= 0; i--)
            { 
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            CountUp(1);
            CountDown(1);
            CountUp(2);
            CountDown(2);
            CountUp(3);
            CountDown(3);
        }
    }
}

