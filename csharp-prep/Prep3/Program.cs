using System;

class Program
{
    static void Main(string[] args)
    {   
        
        /*Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);
        */
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 200);
        int guess;
        
        do 
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > number)
            {
            Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
            Console.WriteLine("Higher");
            }
            else 
            {
            Console.WriteLine("You guessed it!");
            }
        }
        while (guess != number);
    }
}