using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        bool loop = true;
        while (loop)
        {   
            int option;
            string choice = "";
            while (!int.TryParse(choice, out option))
            {
                Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
                choice = Console.ReadLine();
            }
            if(option == 1)
            {
                _journal.NewEntry();
            }
            else if (option == 2)
            {
                _journal.DisplayJournal();
            }
            else if (option == 3)
            {
                Console.WriteLine("What is the filename you would like to load?");
                string filename = Console.ReadLine();
                _journal.ReadJounal(filename);
            }
            else if (option == 4)
            {
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();
                _journal.SaveJournal(filename);
            }
            else if (option == 5)
            {
                loop = false;
            }
            else{
                Console.WriteLine("Please choose one of the listed options: \n");
            }
        }    
    }
}