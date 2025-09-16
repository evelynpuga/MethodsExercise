using System.Globalization;

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

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                //sum = sum + number;
                sum += number;
            }
            return sum;
        }

        static void Main(string[] args)
        {
           //MadLib();
           //Console.WriteLine(Add (numOne:2, numTwo:2));
           //int addedNums = Add(numOne:2, numTwo:2);
           //Console.WriteLine(addedNums);
           //Console.WriteLine(Subtract(numOne:2, numTwo:2));
           //Console.WriteLine(Multiply(numOne:2, numTwo:2));
           //Console.WriteLine(Divide(numOne:2, numTwo:2));
           Console.WriteLine(Sum(5, 5, 5, 5, 6, 7, 5));
        }
    }
}
