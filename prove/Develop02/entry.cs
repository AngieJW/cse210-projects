public class Entry
{
    public List<string> _prompts;
    public string _randomPrompt;
    public string _userInput;
    public string _date;
    public Entry()
        {
            getRandomPrompt();
        }
    public Entry(string answer)
    {
        getRandomPrompt();

        DateTime currentTime = DateTime.Now;
        string dateToday = currentTime.ToShortDateString();
        _date = dateToday;
        _userInput = answer;
    }
     public Entry(string answer, string date, string prompt)
    {
        _randomPrompt = prompt;
        _date = date;
        _userInput = answer;
    }
    public void getRandomPrompt()
    {
        _prompts = new List<string> 
            {"Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Did I help someone today? ",
            "What was the brightest part of my day today ?",
            "What memory do I want to keep from today? ",
            "Who did I connect with today and how? ",
            "What have I prioritized today and was it the right choice?",
            "What did I learn today?"
            };
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        _randomPrompt = _prompts[index];
    }
    public string UserInput()
    {
        string _userInput = Console.ReadLine();
        return _userInput;
    }
}