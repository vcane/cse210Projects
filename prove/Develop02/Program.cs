using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to Your Daily Journal!");

    bool repeat = true;

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
      if (userSelection == "1")
      {
        //call write an entry method
      }
      else if (userSelection == "2")
      {
        //call display your entries method
      }
      else if (userSelection == "3")
      {
        //call load your journal method
      }
      else if (userSelection == "4")
      {
        //call save your journal method
      }
      else
      {
        repeat = false;
        Console.WriteLine("Exiting program, goodbye.");
      }

    }



  }
}