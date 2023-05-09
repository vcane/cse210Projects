using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{

  public List<Entry> _entries = new List<Entry>();

  public void AddEntry()
  {
    // make a while loop with entry = yes, if entry = no then quit loop
    // step 1. make an Entry instance
    // step 2. populate Entry member variables
    //  step 2a. _date = DateTime method
    //  step 2b. display random prompt to user
    //  step 2c. console.ReadLine to gather user's response and store in _response
    // step 3. entryListIndex variable increase by 1 for list index
    // step 4. add Entry instance to _entries list with entryListIndex variable as index
    // step 5. ask user if they want another prompt and to make another entry
    //   step 5a. if yes, continue loop
    //   step 5b. if no, exit loop

    string entryLoop = "yes";
    while (entryLoop == "yes")
    {
      Entry tempEntry = new Entry();
      DateTime theCurrentTime = DateTime.Now;
      tempEntry._date = theCurrentTime.ToShortDateString();

      PromptHandler prompt = new PromptHandler();
      tempEntry._prompt = prompt.GetRandomPrompt();

      // if (_entries.Contains(tempEntry._prompt))
      // {

      // }
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

  public List<Entry> LoadJournal()
  {
    Console.Write("What is the name of your file? ");
    string fileName = Console.ReadLine();
    Console.WriteLine("Reading list from file...");
    List<Entry> entries = new List<Entry>();

    string[] lines = System.IO.File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
      //Console.WriteLine(line);
      string[] parts = line.Split("/n");

      Entry tempEntryFromFile = new Entry();
      tempEntryFromFile._date = parts[0];
      tempEntryFromFile._prompt = parts[1];
      tempEntryFromFile._response = parts[2];

      _entries.Add(tempEntryFromFile);

      // string firstLine = parts[0];
      //string secondLine = parts[1]; I get an out of bounds exception when I include parts[1]. Why?
      // I thought their would be two elements in the string array, because there are two sentences
      // in my test.txt file.
      // Console.WriteLine($"{firstLine}");
    }
    return entries;
  }

  public void SaveJournal()
  {
    Console.Write("Please enter the name of your file. ");
    string fileName = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      for (int i = 0; i < _entries.Count; i++)
      {
        outputFile.WriteLine($"""
        {_entries[i]._date}
        {_entries[i]._prompt}
        {_entries[i]._response}

        """);
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