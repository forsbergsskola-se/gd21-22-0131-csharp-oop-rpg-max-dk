class Program
    {
        static void Main()
        {
            Person human = new Person();
            Animal dog = new Animal();
            Car volvo = new Car();
            
            Console.WriteLine(human);
            Console.WriteLine(dog);
            Console.WriteLine(volvo);
            

            Person[] persons = new Person[3];
            
            
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person();
                Console.WriteLine("Give me a name.");
                persons[i].name = Console.ReadLine();
                
            }

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].IntroduceYourself();
            }

        }
    }


public class Person
{
    public string name;

    public void IntroduceYourself()
    {
        Console.WriteLine($"Hello, my name is {name}");
    }
}   

   

    class Animal
    {
        
    }

    class Car
    {
        
    }

