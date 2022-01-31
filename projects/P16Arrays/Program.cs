namespace P16Arrays
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[11];
            Random random = new Random();
            Console.WriteLine("I will roll 10.000 numbers between 0 and 10:");

            for (int i = 0; i <= 10000; i++)
            {
                int randomNum = random.Next(0, 11);
                array[randomNum]++;
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"I rolled {i} a total of {array[i]}");
            }
           
        }
    }
    
    
}

