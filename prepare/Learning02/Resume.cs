/*
Class: Resume

Attributes:
*name: string
*jobs: List<Job>

Behaviors:
*Display(): void
*/


using System;

public class Resume
{
  //member variables
  public string name;

  // initialize the list to a new List before using it
  public List<Job> jobs = new List<Job>();

  public void Display()
  {
    Console.WriteLine($"Name: {name}");
    Console.WriteLine("Jobs:");
    foreach (Job job in jobs)
    {
      job.Display();
    }
  }
}

