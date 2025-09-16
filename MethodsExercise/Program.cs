namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            // Prompt the user for their name
            Console.WriteLine("What is your name?"); //output
            string name = Console.ReadLine(); //input
            
            //Prompt the user for favorite color
            Console.WriteLine("What is your favorite color?"); //output
            string color = Console.ReadLine(); //input
            
            // Prompt the user for their favorite animal
            Console.WriteLine("What is your favorite animal?"); //output
            string animal = Console.ReadLine(); //input
            
            //Prompt the user for their favorite food
            Console.WriteLine("What is your favorite food?"); //output
            string food = Console.ReadLine();//input
            
            //story read out
            Console.WriteLine($"I have a pet {animal} named {name}. They have a {color} collar. When they are really hungry, I feed them {food}.");
        }
        static void Main(string[] args)
        {
           MadLib();
        }
    }
}
