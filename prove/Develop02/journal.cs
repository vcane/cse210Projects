using System;
using System.IO;

public class Journal
{
  //attribute
  public List<Entry> _entries = new List<Entry>();

  //methods
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
    //int entryListIndex = 0;
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

      _entries.Add(tempEntry);

      Console.Write("Would you like another prompt to make another entry, yes or no? ");
      entryLoop = Console.ReadLine().ToLower();

      // if (entryLoop == "yes")
      // {
      //   entryListIndex += 1;
      // }

    }

    Console.WriteLine("Thank you for making an entry.");
    // tested code to make sure entry was added to _entries list. The entry was added, but not displayed correctly
    // when I attempted to write it to the console. The loop below displayed the output as "Entry" and not date,
    // prompt, and user response.
    // It appears that the AddEntry method works as intended....just need to make it display correctly...

    // Console.WriteLine("Here is your entry(ies)...");
    // foreach (Entry entry in _entries)
    // {
    //   Console.WriteLine(entry);
    // }
  }

  public void LoadJournal()
  {
    Console.Write("What is the name of your file? ");
    string fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
      string[] parts = line.Split("/n");

      string firstLine = parts[0];
      //string secondLine = parts[1]; I get an out of bounds exception when I include parts[1]. Why?
      // I thought their would be two elements in the string array, because there are two sentences
      // in my test.txt file.
      Console.WriteLine($"{firstLine}");
    }
  }

  public void SaveJournal()
  {
    Console.Write("Please enter the name of your file. ");
    string fileName = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      // You can add text to the file with the WriteLine method
      outputFile.WriteLine("This will be the first line in the file.");

      // You can use the $ and include variables just like with Console.WriteLine
      string color = "Blue";
      outputFile.WriteLine($"My favorite color is {color}");
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