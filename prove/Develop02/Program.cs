class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to Your Daily Journal!" + "\n");

    bool repeat = true;
    Journal journal = new Journal();
    while (repeat == true)
    {
      Console.WriteLine("Please select a number from the menu below.");
      Console.WriteLine("""
            1. Write an entry
            2. Display your entries
            3. Load your journal
            4. Save your journal
            5. Quit
            
            """);

      Console.Write("What would you like to do? ");
      string userSelection = Console.ReadLine();
      Console.WriteLine(" ");

      if (userSelection == "1")
      {
        journal.AddEntry();
      }
      else if (userSelection == "2")
      {
        journal.DisplayJournal();
      }
      else if (userSelection == "3")
      {
        journal.LoadJournal();
      }
      else if (userSelection == "4")
      {
        journal.SaveJournal();
      }
      else
      {
        repeat = false;
        Console.WriteLine("Exiting program, goodbye.");
      }
    }
  }
}