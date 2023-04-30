//Class diagrams
/*
Class: Resume

Attributes:
*name: string
*jobs: List<Job>

Behaviors:
*Display(): void

---------------------

Class: Job

Attributes:
*company: string
*jobTitle: string
*startYear: int
*endYear: int

Behaviors:
*Display(): void
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    Job job1 = new Job();
    job1.company = "Microsoft";
    job1.jobTitle = "Software Engineer";
    job1.startYear = 2020;
    job1.endYear = 2022;

    Job job2 = new Job();
    job2.company = "Netflix";
    job2.jobTitle = "Software Developer";
    job2.startYear = 2022;
    job2.endYear = 2023;

    Resume myResume = new Resume();
    myResume.jobs.Add(job1);
    myResume.jobs.Add(job2);
    myResume.name = "Virgil";
    myResume.Display();
  }
}