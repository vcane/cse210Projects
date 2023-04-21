using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Please enter the magic number as an integer 1-10: ");
    string magic = Console.ReadLine();
    int magicNum = int.Parse(magic);
    int guessNum;

    do
    {
      Console.Write("Please enter an integer 1-10: ");
      string guess = Console.ReadLine();
      guessNum = int.Parse(guess);

      if (magicNum < guessNum)
      {
        Console.WriteLine("Your guess is too high!");
      }
      else if (magicNum > guessNum)
      {
        Console.WriteLine("Your guess is too low!");
      }
      else
      {
        Console.WriteLine($"Congratulations, {guessNum} was the correct number!");
      }
    } while (guessNum != magicNum);
  }
}