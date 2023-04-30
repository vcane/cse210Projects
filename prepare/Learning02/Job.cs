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

  // A special method, called a constructor that is invoked using the  
  // new keyword followed by the class name and parentheses.
  // public Job()
  // {
  // }

  //method
  public void Display()
  {
    Console.WriteLine($"{jobTitle} ({company}) {startYear} - {endYear}");
  }
}