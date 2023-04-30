using System;

class Program
{
  static void Main(string[] args)
  {

    DisplayWelcome();
    string userName = PromptUserName();
    int number = PromptUserNumber();
    DisplayResult(userName, SquareNumber(number));
  }
  static int PromptUserNumber()
  {
    Console.Write("Please enter your favorite number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
  }

  static void DisplayResult(string name, int number)
  {
    Console.WriteLine($"{name}, the square of your number is {number}.");
  }

  static int SquareNumber(int number)
  {
    int answer = number * number;
    return answer;
  }

  static string PromptUserName()
  {
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
  }

  static void DisplayWelcome()
  {
    Console.WriteLine("Welcome to the Program!");
  }
}