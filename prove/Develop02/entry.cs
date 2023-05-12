
public class Entry
{
  public string _response;
  public string _prompt;
  public string _date;
  public void DisplayEntry()
  {
    Console.WriteLine($"""
    {_date}
    {_prompt}
    {_response}
    
    """);
  }
}

