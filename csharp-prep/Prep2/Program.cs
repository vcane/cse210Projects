using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Please enter your grade percentage. ");
    string gradePercentage = Console.ReadLine();
    int gradePercentageNum = int.Parse(gradePercentage);
    string finalGrade;
    string sign;

    if (gradePercentage.EndsWith("9") || gradePercentage.EndsWith("8") || gradePercentage.EndsWith("7"))
    {
      sign = "+";
    }
    else if (gradePercentage.EndsWith("2") || gradePercentage.EndsWith("1") || gradePercentage.EndsWith("0"))
    {
      sign = "-";
    }
    else
    {
      sign = "";
    }

    if (gradePercentageNum >= 90)
    {
      finalGrade = "A";
    }
    else if (gradePercentageNum >= 80)
    {
      finalGrade = "B";
    }
    else if (gradePercentageNum >= 70)
    {
      finalGrade = "C";
    }
    else if (gradePercentageNum >= 60)
    {
      finalGrade = "D";
    }
    else
    {
      finalGrade = "F";
    }

    if (gradePercentageNum >= 93 || gradePercentageNum < 60)
    {
      sign = "";
    }

    Console.WriteLine($"Your final letter grade is {finalGrade}{sign}.");
    if (gradePercentageNum >= 70)
    {
      Console.WriteLine("Congratulations, you passed the class!");
    }
    else
    {
      Console.WriteLine("Good try, unfortunately you didn't pass the class! You can pass it next time!");
    }
  }
}