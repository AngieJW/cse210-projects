using System;

class Program
{
    static void Main(string[] args)
    {
        /*general structure of a function definition in C# is:
            static returnType FunctionName(dataType parameter1, dataType parameter2)
            {
                // function_body
            }

            static int AddNumbers(int first, int second)
            {
                int sum = first + second;
                return sum;
            }
        */
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string username, int square)
        {
            Console.WriteLine($"{username}, the square of your number is {square}");
        }
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(username, square);
    }
}