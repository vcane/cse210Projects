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
    Console.WriteLine($"""
    {_date}
    {_prompt}
    {_response}
    """);
  }
}

