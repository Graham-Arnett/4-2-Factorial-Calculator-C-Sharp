namespace Factorial_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");
            String choice;
            do
            {
                Console.Write("Enter an integer that's greater than 0 and less than 10: ");
                int entry = int.Parse(Console.ReadLine());
                if(entry <0 || entry > 10)
                {
                    Console.WriteLine("Invalid, please enter a valid number between 0 and 10.");
                    
                  
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= entry; i++)
                    {
                    factorial *= i;    
                    }
                    
                    Console.WriteLine($"The factorial of {entry} is {factorial}!");
                }
               

                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }while(choice == "y");
        }
    }
}
