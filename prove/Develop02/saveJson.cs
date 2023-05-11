using System.Text.Json;

public class SaveJson
{
  public string _fileName;

  public void SaveJsonFile(List<Entry> _entries)
  {
    Console.WriteLine("What is your file name? ");
    _fileName = Console.ReadLine();

    string jsonString = JsonSerializer.Serialize(_entries);
    File.WriteAllText(_fileName, jsonString);
  }
}