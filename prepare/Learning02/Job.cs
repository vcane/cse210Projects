using System;

// A code template for the category of things known as Job. The
// responsibility of a Job is to hold and display job position information.
public class Job
{
  //member variables
  public string company;
  public string jobTitle;
  public int startYear;
  public int endYear;

  //method
  public void Display()
  {
    Console.WriteLine($"{jobTitle} ({company}) {startYear} - {endYear}");
  }
}