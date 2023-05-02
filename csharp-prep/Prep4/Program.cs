using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int answer;

        do 
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            answer = int.Parse(userInput);
            numbers.Add(answer);
        }
        while (answer != 0);

        int sum = 0;  
        foreach (int number in numbers)
            {
                sum += number;
            }
        Console.WriteLine($"The sum is: {sum}");
        int count = numbers.Count - 1;
        float average = ((float)sum)/ count;
        Console.WriteLine($"The average is: {average}");

        int largest = 0;
        foreach (int number in numbers)
            {
                if (largest < number)
                {
                    largest = number;
                } 
            }
        Console.WriteLine($"The largest number is: {largest}");
/*
        access the items by their index:
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        */
    }
}