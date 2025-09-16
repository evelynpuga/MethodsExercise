namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            //Prompt the user for favorite color
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            
            // Prompt the user for their favorite animal
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            
            //Prompt the user for their favorite food
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            
            Console.WriteLine($"I have a pet {animal} named {name}. They have a {color} collar. When they are really hungry, I feed them {food}.");
            
        }
    }
}
