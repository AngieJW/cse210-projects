public class Journal
{
public List<Entry> _entries;

public Journal()
{
    _entries = new List<Entry>();
}

public void NewEntry (string answer = null, string date = null, string prompt = null)
    {
        if (answer == null)
        {
            Entry _newEntry = new Entry();
            Console.WriteLine(_newEntry._randomPrompt);
            answer = _newEntry.UserInput();
            _newEntry._userInput = answer;
            _entries.Add(_newEntry);
        }
        else if (prompt != null)
        {
            Entry newEntry = new Entry(answer, date, prompt);
            _entries.Add(newEntry);
        }
        else{
            Entry newEntry = new Entry(answer);
            _entries.Add(newEntry);        
        }
    }

 public void DisplayJournal ()
    {
        foreach(Entry i in _entries)
        {
            string date = i._date;
            string prompt = i._randomPrompt;
            string answer = i._userInput;
            Console.WriteLine($"Date: {date} - Prompt: {prompt}\n{answer}\n");
        }
    }
public void ReadJounal (string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] sections = line.Split("&");
            string date = sections[0];
            string prompt = sections[1];
            string answer = sections[2];
            NewEntry(answer, date, prompt);
        }
    }

public void SaveJournal (string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach(Entry i in _entries)
            {
                string date = i._date;
                string prompt = i._randomPrompt;
                string answer = i._userInput;
                file.WriteLine($"{date}&{prompt}&{answer}");
            }
        }
    }

}
