using System;

public class Entry
{

  //attributes
  public string _date;
  public string _prompt;
  public string _response;

  //method
  public void DisplayEntry()
  {
    DateTime theCurrentTime = DateTime.Now;
    _date = theCurrentTime.ToShortDateString();
    Console.WriteLine(_date);

    PromptHandler prompt = new PromptHandler();
    _prompt = prompt.GetRandomPrompt();
    Console.WriteLine(_prompt);

    Console.Write("> ");
    _response = Console.ReadLine();
    Console.WriteLine(_response);
  }
}

