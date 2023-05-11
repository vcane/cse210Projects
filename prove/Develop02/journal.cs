public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry()
  {
    string entryLoop = "yes";
    while (entryLoop == "yes")
    {
      Entry tempEntry = new Entry();

      DateTime theCurrentTime = DateTime.Now;
      tempEntry._date = theCurrentTime.ToShortDateString();

      PromptHandler prompt = new PromptHandler();
      tempEntry._prompt = prompt.GetRandomPrompt();

      Console.WriteLine(tempEntry._prompt);

      Console.Write("> ");
      tempEntry._response = Console.ReadLine();

      Console.WriteLine(" ");

      _entries.Add(tempEntry);

      Console.Write("Would you like another prompt to make another entry, yes or no? ");
      entryLoop = Console.ReadLine().ToLower();
    }
    Console.WriteLine("Thank you for making an entry.");
  }

  public void LoadJournal()
  {
    Console.Write("What is the name of your file? ");
    string fileName = Console.ReadLine();
    Console.WriteLine("Reading list from file...");

    string[] lines = File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
      string[] parts = line.Split("~~");

      Entry tempEntryFromFile = new Entry();
      tempEntryFromFile._date = parts[0];
      tempEntryFromFile._prompt = parts[1];
      tempEntryFromFile._response = parts[2];

      _entries.Add(tempEntryFromFile);
    }
  }

  public void SaveJournal()
  {
    Console.Write("Please enter the name of your file. ");
    string fileName = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      for (int i = 0; i < _entries.Count; i++)
      {
        outputFile.WriteLine($"{_entries[i]._date}~~{_entries[i]._prompt}~~{_entries[i]._response}");
      }

    }
    Console.WriteLine("Saving to file....");
  }

  public void DisplayJournal()
  {
    foreach (Entry entry in _entries)
    {
      entry.DisplayEntry();
    }
  }
}