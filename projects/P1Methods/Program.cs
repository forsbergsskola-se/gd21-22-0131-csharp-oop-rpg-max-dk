namespace P1Methods
{
    class Program
    {
        static void CountUp()
        {
            Console.WriteLine("Counting from 1 to 5");
            for (int i = 0; i <= 5; i++)
            { 
                Console.WriteLine(i);
            }
        }
        static void CountDown()
        {
            Console.WriteLine("Counting from 5 to 0");
            for (int i = 5; i >= 0; i--)
            { 
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            CountUp();
            CountDown();
            CountUp();
            CountDown();
        }
    }
}

